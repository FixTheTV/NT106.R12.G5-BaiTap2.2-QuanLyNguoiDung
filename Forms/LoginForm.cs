using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiDungWinForms
{
    public partial class LoginForm : Form
    {
        private readonly DatabaseAccess _dbAccess = new DatabaseAccess();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnToggleMatKhau_Click(object? sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
            btnToggleMatKhau.Text = txtMatKhau.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private async void BtnDangNhap_Click(object? sender, EventArgs e)
        {
            lblThongBaoLoi.Text = "";

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            // 1. Kiểm tra rỗng trên Form trước khi gọi DB
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                lblThongBaoLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                if (string.IsNullOrEmpty(tenDangNhap)) txtTenDangNhap.Focus();
                else txtMatKhau.Focus();
                return;
            }

            // 2. Khóa nút bấm và đổi nhãn trong khi xử lý
            btnDangNhap.Enabled = false;
            btnThoat.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";

            try
            {
                NguoiDung? user = await _dbAccess.LayTheoTenDangNhapAsync(tenDangNhap);

                // QUY TẮC BÀI TẬP: Dù sai tên đăng nhập hay sai mật khẩu, chỉ trả về đúng 1 thông báo duy nhất
                if (user == null)
                {
                    lblThongBaoLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                bool hopLe = MatKhauHelper.KiemTra(matKhau, user.Salt, user.MatKhauBam);
                if (!hopLe)
                {
                    lblThongBaoLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                await _dbAccess.CapNhatLanDangNhapCuoiAsync(user.UserId);
                user.LanDangNhapCuoi = DateTime.Now;

                MainForm mainForm = new MainForm(user, this);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                lblThongBaoLoi.Text = ex.Message;
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnThoat.Enabled = true;
                btnDangNhap.Text = "ĐĂNG NHẬP";
            }
        }

        private void LnkDangKy_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            lblThongBaoLoi.Text = "";
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.Show();
            this.Hide();
        }

        private void BtnThoat_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
