using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDungWinForms
{
    public partial class RegisterForm : Form
    {
        private readonly Form _loginForm;
        private readonly DatabaseAccess _dbAccess = new DatabaseAccess();

        public RegisterForm(Form loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void BtnToggleMatKhau_Click(object? sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
            btnToggleMatKhau.Text = txtMatKhau.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void BtnToggleXacNhan_Click(object? sender, EventArgs e)
        {
            txtXacNhanMatKhau.UseSystemPasswordChar = !txtXacNhanMatKhau.UseSystemPasswordChar;
            btnToggleXacNhan.Text = txtXacNhanMatKhau.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void XoaTatCaThongBaoLoi()
        {
            lblLoiTenDangNhap.Text = "";
            lblLoiEmail.Text = "";
            lblLoiSoDienThoai.Text = "";
            lblLoiDoTuoi.Text = "";
            lblLoiMatKhau.Text = "";
            lblLoiXacNhanMatKhau.Text = "";
            lblLoiHoTen.Text = "";
            lblThongBaoChung.Text = "";
        }

        private async void BtnDangKy_Click(object? sender, EventArgs e)
        {
            XoaTatCaThongBaoLoi();

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string doTuoiStr = txtDoTuoi.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;
            string hoTen = txtHoTen.Text.Trim();

            bool hopLe = true;
            TextBox? focusControl = null;

            // 1. Kiểm tra Tên đăng nhập (3 - 20 ký tự)
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập không được để trống!";
                hopLe = false;
                focusControl ??= txtTenDangNhap;
            }
            else if (!Regex.IsMatch(tenDangNhap, @"^[a-zA-Z0-9_]{3,20}$"))
            {
                lblLoiTenDangNhap.Text = "Tên đăng nhập từ 3 - 20 ký tự (chữ cái, chữ số, gạch dưới).";
                hopLe = false;
                focusControl ??= txtTenDangNhap;
            }

            // 2. Kiểm tra Email
            if (string.IsNullOrEmpty(email))
            {
                lblLoiEmail.Text = "Email không được để trống!";
                hopLe = false;
                focusControl ??= txtEmail;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblLoiEmail.Text = "Định dạng email không hợp lệ (ví dụ: ten@mien.com).";
                hopLe = false;
                focusControl ??= txtEmail;
            }

            // 3. Kiểm tra Số điện thoại
            if (string.IsNullOrEmpty(sdt))
            {
                lblLoiSoDienThoai.Text = "Số điện thoại không được để trống!";
                hopLe = false;
                focusControl ??= txtSoDienThoai;
            }
            else if (!Regex.IsMatch(sdt, @"^(\+84|0)[0-9]{9,10}$"))
            {
                lblLoiSoDienThoai.Text = "Số điện thoại không hợp lệ (mẫu: +84912345678 hoặc 0912345678).";
                hopLe = false;
                focusControl ??= txtSoDienThoai;
            }

            // 4. Kiểm tra Độ tuổi
            if (string.IsNullOrEmpty(doTuoiStr))
            {
                lblLoiDoTuoi.Text = "Độ tuổi không được để trống!";
                hopLe = false;
                focusControl ??= txtDoTuoi;
            }
            else if (!int.TryParse(doTuoiStr, out int doTuoi) || doTuoi < 16)
            {
                lblLoiDoTuoi.Text = "Yêu cầu độ tuổi là số nguyên từ 16 tuổi trở lên!";
                hopLe = false;
                focusControl ??= txtDoTuoi;
            }

            // 5. Kiểm tra Mật khẩu
            if (string.IsNullOrEmpty(matKhau))
            {
                lblLoiMatKhau.Text = "Mật khẩu không được để trống!";
                hopLe = false;
                focusControl ??= txtMatKhau;
            }
            else if (matKhau.Length < 8)
            {
                lblLoiMatKhau.Text = "Mật khẩu tối thiểu phải từ 8 ký tự trở lên!";
                hopLe = false;
                focusControl ??= txtMatKhau;
            }

            // 6. Kiểm tra Xác nhận mật khẩu
            if (string.IsNullOrEmpty(xacNhanMatKhau))
            {
                lblLoiXacNhanMatKhau.Text = "Vui lòng nhập lại mật khẩu để xác nhận!";
                hopLe = false;
                focusControl ??= txtXacNhanMatKhau;
            }
            else if (matKhau != xacNhanMatKhau)
            {
                lblLoiXacNhanMatKhau.Text = "Mật khẩu xác nhận không trùng khớp!";
                hopLe = false;
                focusControl ??= txtXacNhanMatKhau;
            }

            // 7. Kiểm tra Họ và tên
            if (string.IsNullOrEmpty(hoTen))
            {
                lblLoiHoTen.Text = "Họ và tên không được để trống!";
                hopLe = false;
                focusControl ??= txtHoTen;
            }
            else if (hoTen.Length < 2 || hoTen.Length > 50)
            {
                lblLoiHoTen.Text = "Họ và tên phải từ 2 đến 50 ký tự!";
                hopLe = false;
                focusControl ??= txtHoTen;
            }

            if (!hopLe)
            {
                focusControl?.Focus();
                return;
            }

            btnDangKy.Enabled = false;
            btnHuy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                var (salt, bam) = MatKhauHelper.Tao(matKhau);

                NguoiDung userMoi = new NguoiDung
                {
                    TenDangNhap = tenDangNhap,
                    MatKhauBam = bam,
                    Salt = salt,
                    Email = email,
                    SoDienThoai = sdt,
                    DoTuoi = int.Parse(doTuoiStr),
                    HoTen = hoTen
                };

                bool ketQua = await _dbAccess.ThemNguoiDungAsync(userMoi);
                if (ketQua)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công! Vui lòng đăng nhập.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _loginForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                lblThongBaoChung.Text = ex.Message;
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnHuy.Enabled = true;
                btnDangKy.Text = "ĐĂNG KÝ";
            }
        }

        private void BtnHuy_Click(object? sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }
    }
}
