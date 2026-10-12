using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNguoiDungWinForms
{
    public partial class MainForm : Form
    {
        private readonly NguoiDung _userCurrentUser;
        private readonly Form _loginForm;

        public MainForm(NguoiDung user, Form loginForm)
        {
            _userCurrentUser = user;
            _loginForm = loginForm;
            InitializeComponent();
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            lblXinChao.Text = $"Xin chào, {_userCurrentUser.HoTen}!";
            lblTenDangNhapVal.Text = _userCurrentUser.TenDangNhap;
            lblEmailVal.Text = _userCurrentUser.Email ?? "Chưa cập nhật";
            lblSoDienThoaiVal.Text = _userCurrentUser.SoDienThoai ?? "Chưa cập nhật";
            lblDoTuoiVal.Text = _userCurrentUser.DoTuoi.HasValue ? _userCurrentUser.DoTuoi.Value.ToString() : "N/A";
            lblNgayTaoVal.Text = _userCurrentUser.NgayTao.ToString("dd/MM/yyyy HH:mm");
            lblLanDangNhapCuoiVal.Text = _userCurrentUser.LanDangNhapCuoi.HasValue ? _userCurrentUser.LanDangNhapCuoi.Value.ToString("dd/MM/yyyy HH:mm") : "Lần đầu đăng nhập";
        }

        private void BtnDangXuat_Click(object? sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!_loginForm.Visible)
            {
                _loginForm.Show();
            }
        }
    }
}
