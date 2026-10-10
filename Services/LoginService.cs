using System;
using System.Collections.Generic;
using System.Text;

namespace NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Services
{
    // Xử lý đăng nhập 
    internal class LoginService
    {
        // service lấy thông tin tài khoản từ MySQL
        private readonly DatabaseService _databaseService;
        // service dùng để xác minh mật khẩu với BCrypt hash
        private readonly AuthService _authService;
        // Khởi tại services cần dùng khi đăng nhập
        public LoginService()
        {
            _databaseService = new DatabaseService();
            _authService = new AuthService();
        }

        // Đăng nhập bằng username hoặc email
        // trả về true gán thông tin user nếu đăng nhập thành công
        public bool TryLogin(string identifier, string password, out User? user)  //để user có thể nhận giá trị null khi đang nhập thất bại 
        {
            // mặc đinh chưa xác thực được tài khoản 
            user = null;

            // Không truy vấn database néu thiếu username/email hoặc mật khẩu
            if(string.IsNullOrWhiteSpace(identifier) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // dùng database để tìm tài khoản theo username/enail
            User? founduser = _databaseService.GetUserByIdentifier(identifier.Trim());

            // Không tìm thấy -> đăng nhập thất bại
            if (founduser == null)
            {
                return false;
            }
            
            // so sánh mật khẩu với hash  được lưu có trong database + kiểm tra
            bool passwordIsValid = _authService.VerifyPassword(password, founduser.PasswordHash);
            if (!passwordIsValid)
            {
                return false;
            }

            // Xác thực thành công, trả về thông tin user   
            user = founduser;
            return true;
        }
    }
}
