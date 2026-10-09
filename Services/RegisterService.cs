using System;
using System.Text.RegularExpressions;

namespace NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Services
{
    public class RegisterService
    {
        private DatabaseService db = new DatabaseService();
        private AuthService auth = new AuthService();

        public string Register(string username, string password, string confirmPassword,
                               string fullname, string email, string phone, string ageText)
        {
            // 1 Kiểm tra Username
            if (string.IsNullOrWhiteSpace(username))
                return "Vui lòng nhập tên đăng nhập"; 

            if (username.Length < 3 || username.Length > 20)
                return "Tên đăng nhập phải có từ 3 đến 20 ký tự"; 

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
                return "Tên đăng nhập không được chứa khoảng trắng hoặc ký tự đặc biệt"; 

            if (db.CheckUsernameExists(username))
                return "Tên đăng nhập này đã có người sử dụng"; 

            // 2 Kiểm tra Email
            if (string.IsNullOrWhiteSpace(email))
                return "Vui lòng nhập địa chỉ email."; 

            if (!Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
                return "Email không hợp lệ. Vui lòng kiểm tra lại"; 

            if (db.CheckEmailExists(email))
                return "Email này đã được đăng ký"; 

            // 3 Kiểm tra Mật khẩu
            if (string.IsNullOrEmpty(password))
                return "Mật khẩu không được để trống"; 

            bool isLengthValid = password.Length >= 8 && password.Length <= 32; 
            bool hasUpper = Regex.IsMatch(password, @"[A-Z]"); 
            bool hasLower = Regex.IsMatch(password, @"[a-z]"); 
            bool hasDigit = Regex.IsMatch(password, @"[0-9]"); 
            bool hasSpecial = Regex.IsMatch(password, @"[@$,!%*?&]");

            if (!isLengthValid || !hasUpper || !hasLower || !hasDigit || !hasSpecial)
                return "Mật khẩu phải từ 8-32 ký tự, bao gồm chữ cái, số và ký tự đặc biệt"; 

            // 4 Kiểm tra Xác nhận mật khẩu
            if (string.IsNullOrEmpty(confirmPassword))
                return "Xác nhận mật khẩu không được để trống."; 

            if (password != confirmPassword)
                return "Mật khẩu xác nhận không khớp."; 

            // 5 Kiểm tra tuổi
            int? age = null;
            if (!string.IsNullOrWhiteSpace(ageText))
            {
                if (int.TryParse(ageText, out int parsedAge))
                    age = parsedAge;
                else
                    return "Độ tuổi phải là số nguyên.";
            }

            // 6 Băm và lưu vào DB
            try
            {
                string passwordHash = auth.HashPassword(password);
                bool ok = db.AddUser(username, passwordHash, fullname, email, phone, age);
                if (!ok) return "Lỗi, không thể lưu tài khoản vào cơ sở dữ liệu.";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối cơ sở dữ liệu: " + ex.Message;
            }

            return ""; // Đăng ký thành công
        }
    }
}