using System;
using System.Collections.Generic;
using System.Text;

namespace NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Services
{
    public class AuthService //có 2 chức năng: HashPassword và VerifyPassword
    {
        //thư viện BCrypt tự động sinh ra 1 chuối ngẫu nhiên(salt) gắn kèm vào password mỗi lần băm
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
        //cơ chế hàm verify:
        //1. đọc chuỗi hashedpassword lấy từ database để trích xuất ra giá trị salt cũ đã dùng trước đây
        //2. dùng chính salt cũ đó để băm password mà người dùng mới nhập vào để đăng nhập
        //3. so sánh kết quả băm mới này với chuỗi hashedpassword trong database:
        // nếu khớp : trả về bool=true
        //sai thì false
    }
}
