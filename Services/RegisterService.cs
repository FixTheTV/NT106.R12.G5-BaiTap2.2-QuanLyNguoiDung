using System;
using System.Text.RegularExpressions;  // Regex: Regular Expression (biểu thức chính quy) để kiểm tra định dạng chuỗi
using NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Models; // Dùng model RegisterResult từ file RegisterResult.cs cho hàm register 

namespace NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Services
{
    public class RegisterService
    {
        private DatabaseService db = new DatabaseService();
        private AuthService auth = new AuthService();

        public RegisterResult Register(string username, string password, string confirmPassword,
                               string fullname, string email, string phone, string ageText)             //hàm Register trả về kiểu dữ liệu là RegisterResult, 
        {

            //  KIỂM TRA ĐỊNH DẠNG CỤC BỘ (LOCAL VALIDATION - chưa GỌI DATABASE)
            // Kiểm tra Username
            if (string.IsNullOrWhiteSpace(username))
                return new RegisterResult { Success = false, Message = "Vui lòng nhập tên đăng nhập." }; 

            if (username.Length < 3 || username.Length > 20)
                return new RegisterResult { Success = false, Message = "Tên đăng nhập phải có từ 3 đến 20 ký tự." }; 

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
                return new RegisterResult { Success = false, Message = "Tên đăng nhập không được chứa khoảng trắng hoặc ký tự đặc biệt." }; 

            // Kiểm tra Email
            if (string.IsNullOrWhiteSpace(email))
                return new RegisterResult { Success = false, Message = "Vui lòng nhập địa chỉ email." }; 

            if (!Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
                return new RegisterResult { Success = false, Message = "Email không hợp lệ. Vui lòng kiểm tra lại." }; 

            // Kiểm tra Mật khẩu
            if (string.IsNullOrEmpty(password))
                return new RegisterResult { Success = false, Message = "Mật khẩu không được để trống." }; 

            bool isLengthValid = password.Length >= 8 && password.Length <= 32;
            bool hasUpper = Regex.IsMatch(password, @"[A-Z]");
            bool hasLower = Regex.IsMatch(password, @"[a-z]");
            bool hasDigit = Regex.IsMatch(password, @"[0-9]");
            bool hasSpecial = Regex.IsMatch(password, @"[@$,!%*?&]");

            if (!isLengthValid || !hasUpper || !hasLower || !hasDigit || !hasSpecial)
                return new RegisterResult { Success = false, Message = "Mật khẩu phải từ 8-32 ký tự, bao gồm chữ cái, số và ký tự đặc biệt." };

            // Kiểm tra Xác nhận mật khẩu
            if (string.IsNullOrEmpty(confirmPassword))
                return new RegisterResult { Success = false, Message = "Xác nhận mật khẩu không được để trống." };

            if (password != confirmPassword)
                return new RegisterResult { Success = false, Message = "Mật khẩu xác nhận không khớp." };

            // Kiểm tra Tuổi
            int? age = null;
            if (!string.IsNullOrWhiteSpace(ageText))
            {
                if (int.TryParse(ageText, out int parsedAge))
                    age = parsedAge;
                else
                    return new RegisterResult { Success = false, Message = "Độ tuổi phải là số nguyên." };
            }


            // SAU ĐÓ: KIỂM TRA TRÙNG LẶP TRÊN DATABASE (SERVER VALIDATION)


            try
            {
                if (db.CheckUsernameExists(username))
                    return new RegisterResult { Success = false, Message = "Tên đăng nhập này đã có người sử dụng." }; [cite: 8]

                if (db.CheckEmailExists(email))
                    return new RegisterResult { Success = false, Message = "Email này đã được đăng ký." }; [cite: 8]

                string passwordHash = auth.HashPassword(password);
                bool ok = db.AddUser(username, passwordHash, fullname, email, phone, age);
                if (!ok)
                    return new RegisterResult { Success = false, Message = "Không thể lưu tài khoản vào cơ sở dữ liệu." };
            }
            catch (Exception ex)
            {
                return new RegisterResult { Success = false, Message = "Lỗi kết nối cơ sở dữ liệu: " + ex.Message };
            }



            // Đăng ký thành công
            return new RegisterResult { Success = true, Message = "Đăng ký tài khoản thành công!" };
        }
    }
}