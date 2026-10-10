using MySqlConnector; //  cung cấp các class để làm việc với MySQL
using System;
//file nay  de Chứa class User và tầng giao tiếp MySQL
namespace NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Services
{
    // Class chứa dữ liệu User để hiển thị lên Form Home
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; //khởi tạo mặc định là chuỗi rỗng 
        public string PasswordHash { get; set; } = string.Empty;
        public string? Fullname { get; set; } //co the null, nhung string la kieu tham chieu co the nhan gia tri null, nen khong can "null?"
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public int? Age { get; set; } //int? vi Age co the co gia tri hoac null(tuy ngdung muon nhap hay ko)
    }

    public class DatabaseService
    {
        //chuoi ket noi mac dinh den MySQL cua XAMPP tren cong 3306
        // Server=localhost (chạy trên máy bạn), Port 3306 (cổng MySQL của XAMPP)
        // Uid=root (tài khoản cao nhất), Pwd=; (mật khẩu rỗng)
        private string connectionString = "Server=localhost;Port=3306;Database=user_management;Uid=root;Pwd=;";
        public DatabaseService() //hàm khởi tạo mặc định, không có tham số
        {
        }
        //hàm tạo đối tượng kết nối mới
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Hàm void tự động tạo bảng users nếu chưa có 
        public void CreateTableUsers()
        {
            using (var conn = GetConnection()) // Dùng lại GetConnection() có sẵn trong chính class ni luôn, để tận dụng hàm GetConnection() private của class này  
            {
                conn.Open();
                string sql = @"
            CREATE TABLE IF NOT EXISTS users (
                id INT AUTO_INCREMENT PRIMARY KEY,
                username VARCHAR(20) NOT NULL UNIQUE,
                password_hash VARCHAR(255) NOT NULL,
                fullname VARCHAR(100) NULL,
                email VARCHAR(100) NOT NULL UNIQUE,
                phone VARCHAR(15) NULL,
                age INT NULL
            );";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();  //ExecuteNonQuery(): Thực hiện câu lệnh SQL mà không trả về dữ liệu
                }
            }
        }



        //hàm kiểm tra username đã tồn tại chưa
        public bool CheckUsernameExists(string username)
        {
            //lệnh using + tao doi tuong conn de tao ket noi toi database va tự động gọi hàm Dispose() để đóng kết nối-giải phóng tài nguyên  (Ngay khi kết thúc hàm using này / xảy ra lỗi, kết nối tới database sẽ luôn luôn được đóng lại, tránh rò rỉ kết nối )
            using (var conn = GetConnection())  //var tự hiểu trả về đúng kiểu dữ liệu ở vế bên phải
            {
                conn.Open(); //mở cổng kết nối tới server MySQL de san sang truy van
                string sql = "SELECT COUNT(*) FROM users WHERE username = @u";// Câu lệnh đếm xem có bao nhiêu dòng có username này 
                using (var cmd = new MySqlCommand(sql, conn)) //khoi tao doi tuong lenh cmd: ket hop cau truy van sql ben tren + ket noi conn, dong thoi dung using de tu dong huy lenh khi khi dung xong
                {
                    cmd.Parameters.AddWithValue("@u", username);//@u là tham số (Parameter): Giúp chống lỗi SQL Injection. 
                    //  Gan gia tri bien username vao vi tri tham so @u la cach de chong tan cong SQL Injection(@u duoc coi la van ban thuan, khong bien dich thanh lenh)
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0; //ExecuteScalar(): Chỉ lấy về duy nhất 1 ô dữ liệu ở dòng 1 cột 1 (ở đây là số đếm COUNT) tu doi tuong cmd duoc tra ve tu MySQL, sau do ep kieu sang so nguyen int de xu ly
                                                                     //tra ham isusenameexit ve:count>0 thi true(co nguoi da dat ten nay roi)
                }
            }

        }
        //kiem tra email da ton tai chua
        public bool CheckEmailExists(string email)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM users WHERE email = @e";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@e", email);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

        }

        //Add tài khoản mới vào database đầy đủ các trường thông tin
        public bool AddUser(string username, string passwordHash, string fullname, string email, string phone, int? age)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO users (username, password_hash, fullname, email, phone, age) VALUES (@u, @p, @f, @e, @ph, @a)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", passwordHash);
                    cmd.Parameters.AddWithValue("@f", string.IsNullOrWhiteSpace(fullname) ? DBNull.Value : (object)fullname.Trim());
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@ph", string.IsNullOrWhiteSpace(phone) ? DBNull.Value : (object)phone.Trim());
                    cmd.Parameters.AddWithValue("@a", age.HasValue ? (object)age.Value : DBNull.Value); //neu age co gia tri thi lay gia tri do, neu null thi gan DBNull.Value
                    return cmd.ExecuteNonQuery() > 0; //ExecuteNonQuery(): Thực hiện câu lệnh SQL mà không trả về dữ liệu (ở đây là INSERT), trả về số dòng bị ảnh hưởng. Nếu >0 thì thêm thành công
                }
            }
        }
        //Ham tra ve User:  Lấy toàn bộ thông tin User theo username hoặc email(khi login-de sau nay hien thi all rgong tin trong man hinh dang nhap chang han)
        public User? GetUserByIdentifier(string identifier)  // Thêm dấu ? để thể hiện hàm có thể trả về null nếu không tìm thấy User
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM users WHERE username = @id OR email = @id LIMIT 1"; //Select *: select all thong tin cuar tat ca cac cot trong dong tim duoc(thoa dieu kien where...) tu bang users, WHERE: dieu kien username hoac email phai trung voi identifier, LIMIT 1: chi lay 1 dong du lieu dau tien
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", identifier); // bien @id duoc gan bang gia tri cua bien identifier (username hoac email) duoc truYEN VAO HAM NAY BAN DAU
                    using (var reader = cmd.ExecuteReader())  //cmd.ExecuteReader() GUI cau lenh sql len database de mo luong read du lieu tra ve. Ket qua duoc quan ly bang doi tuong reader
                    {
                        if (reader.Read())  //if(true) neu read duoc(tim duoc) tai khoan hop le voi identifier, neu false thi khong tim thay user nao
                        {
                            return new User //if(true) thi moi thuc hien return ham ban dau ve 1 doi tuong User moi va gan gia tri cho cac thuoc tinh cua User tu du lieu doc duoc tu database
                            {
                                Id = reader.GetInt32("id"),  //lay gia tri int tu cot id
                                Username = reader.GetString("username"),
                                PasswordHash = reader.GetString("password_hash"),
                                Fullname = reader.IsDBNull(reader.GetOrdinal("fullname")) ? null : reader.GetString("fullname"),  //ham kiem tra neu cot fullname rong thi tra ve null. co gia tri thi gettring tu cot fullname
                                Email = reader.GetString("email"),
                                Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? null : reader.GetString("phone"),
                                Age = reader.IsDBNull(reader.GetOrdinal("age")) ? (int?)null : reader.GetInt32("age")
                            };
                        }
                    }
                }
            }
            //chay het lenh tren ma ko return co nghia la ko tim thay User hop le voi identifier, tra ham GetUser ve null 
            return null; //nếu không tìm thấy user nào thì trả về null
        }
    }
}
