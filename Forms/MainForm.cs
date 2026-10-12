using System;
using System.Drawing;
using System.Windows.Forms;
using NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Services;

namespace QuanLyNguoiDungWinForms
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;
        private readonly Form _loginForm;

        public MainForm(User user, Form loginForm)
        {
            _currentUser = user;
            _loginForm = loginForm;
            InitializeComponent();
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            lblXinChao.Text = $"Xin chào, {_currentUser.Fullname ?? _currentUser.Username}!";
            lblTenDangNhapVal.Text = _currentUser.Username;
            lblEmailVal.Text = _currentUser.Email ?? "Chưa cập nhật";
            lblSoDienThoaiVal.Text = _currentUser.Phone ?? "Chưa cập nhật";
            lblDoTuoiVal.Text = _currentUser.Age?.ToString() ?? "N/A";
            lblNgayTaoVal.Text = "N/A";
            lblLanDangNhapCuoiVal.Text = "N/A";
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
