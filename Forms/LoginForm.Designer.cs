namespace QuanLyNguoiDungWinForms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cardPanel = new Panel();
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            pnlMatKhau = new Panel();
            txtMatKhau = new TextBox();
            btnToggleMatKhau = new Button();
            chkGhiNho = new CheckBox();
            lnkQuenMatKhau = new LinkLabel();
            lblThongBaoLoi = new Label();
            btnDangNhap = new Button();
            lnkDangKy = new LinkLabel();
            btnThoat = new Button();
            cardPanel.SuspendLayout();
            pnlMatKhau.SuspendLayout();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.White;
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Controls.Add(lblTieuDe);
            cardPanel.Controls.Add(lblTenDangNhap);
            cardPanel.Controls.Add(txtTenDangNhap);
            cardPanel.Controls.Add(lblMatKhau);
            cardPanel.Controls.Add(pnlMatKhau);
            cardPanel.Controls.Add(chkGhiNho);
            cardPanel.Controls.Add(lnkQuenMatKhau);
            cardPanel.Controls.Add(lblThongBaoLoi);
            cardPanel.Controls.Add(btnDangNhap);
            cardPanel.Controls.Add(lnkDangKy);
            cardPanel.Controls.Add(btnThoat);
            cardPanel.Location = new Point(32, 25);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(420, 510);
            cardPanel.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(30, 30, 30);
            lblTieuDe.Location = new Point(30, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(360, 35);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Đăng nhập";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTenDangNhap.ForeColor = Color.FromArgb(40, 40, 40);
            lblTenDangNhap.Location = new Point(30, 65);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(360, 22);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập (*)";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10.5F);
            txtTenDangNhap.Location = new Point(30, 90);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(360, 31);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.FromArgb(40, 40, 40);
            lblMatKhau.Location = new Point(30, 135);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(360, 22);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu (*)";
            // 
            // pnlMatKhau
            // 
            pnlMatKhau.BorderStyle = BorderStyle.FixedSingle;
            pnlMatKhau.Controls.Add(txtMatKhau);
            pnlMatKhau.Controls.Add(btnToggleMatKhau);
            pnlMatKhau.Location = new Point(30, 160);
            pnlMatKhau.Name = "pnlMatKhau";
            pnlMatKhau.Size = new Size(360, 32);
            pnlMatKhau.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 10.5F);
            txtMatKhau.Location = new Point(2, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(315, 24);
            txtMatKhau.TabIndex = 0;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnToggleMatKhau
            // 
            btnToggleMatKhau.Cursor = Cursors.Hand;
            btnToggleMatKhau.FlatAppearance.BorderSize = 0;
            btnToggleMatKhau.FlatStyle = FlatStyle.Flat;
            btnToggleMatKhau.Font = new Font("Segoe UI", 9F);
            btnToggleMatKhau.Location = new Point(320, 1);
            btnToggleMatKhau.Name = "btnToggleMatKhau";
            btnToggleMatKhau.Size = new Size(36, 28);
            btnToggleMatKhau.TabIndex = 1;
            btnToggleMatKhau.Text = "👁";
            btnToggleMatKhau.UseVisualStyleBackColor = true;
            btnToggleMatKhau.Click += BtnToggleMatKhau_Click;
            // 
            // chkGhiNho
            // 
            chkGhiNho.Font = new Font("Segoe UI", 9F);
            chkGhiNho.ForeColor = Color.FromArgb(80, 80, 80);
            chkGhiNho.Location = new Point(30, 202);
            chkGhiNho.Name = "chkGhiNho";
            chkGhiNho.Size = new Size(230, 24);
            chkGhiNho.TabIndex = 2;
            chkGhiNho.Text = "Ghi nhớ lịch sử đăng nhập";
            chkGhiNho.UseVisualStyleBackColor = true;
            // 
            // lnkQuenMatKhau
            // 
            lnkQuenMatKhau.Font = new Font("Segoe UI", 9F);
            lnkQuenMatKhau.LinkColor = Color.FromArgb(0, 122, 255);
            lnkQuenMatKhau.Location = new Point(250, 205);
            lnkQuenMatKhau.Name = "lnkQuenMatKhau";
            lnkQuenMatKhau.Size = new Size(140, 24);
            lnkQuenMatKhau.TabIndex = 3;
            lnkQuenMatKhau.TabStop = true;
            lnkQuenMatKhau.Text = "Quên mật khẩu?";
            lnkQuenMatKhau.TextAlign = ContentAlignment.TopRight;
            // 
            // lblThongBaoLoi
            // 
            lblThongBaoLoi.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblThongBaoLoi.ForeColor = Color.Red;
            lblThongBaoLoi.Location = new Point(30, 232);
            lblThongBaoLoi.Name = "lblThongBaoLoi";
            lblThongBaoLoi.Size = new Size(360, 38);
            lblThongBaoLoi.TabIndex = 4;
            lblThongBaoLoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(0, 132, 255);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(30, 275);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(360, 45);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += BtnDangNhap_Click;
            // 
            // lnkDangKy
            // 
            lnkDangKy.Font = new Font("Segoe UI", 9.5F);
            lnkDangKy.LinkColor = Color.FromArgb(0, 122, 255);
            lnkDangKy.Location = new Point(30, 350);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(230, 35);
            lnkDangKy.TabIndex = 5;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Chưa có tài khoản? Đăng ký ngay";
            lnkDangKy.TextAlign = ContentAlignment.MiddleLeft;
            lnkDangKy.LinkClicked += LnkDangKy_LinkClicked;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(230, 230, 230);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(60, 60, 60);
            btnThoat.Location = new Point(280, 345);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 40);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += BtnThoat_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnDangNhap;
            BackColor = Color.FromArgb(245, 247, 250);
            CancelButton = btnThoat;
            ClientSize = new Size(484, 561);
            Controls.Add(cardPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            pnlMatKhau.ResumeLayout(false);
            pnlMatKhau.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel cardPanel;
        public System.Windows.Forms.Label lblTieuDe;
        public System.Windows.Forms.Label lblTenDangNhap;
        public System.Windows.Forms.TextBox txtTenDangNhap;
        public System.Windows.Forms.Label lblMatKhau;
        public System.Windows.Forms.Panel pnlMatKhau;
        public System.Windows.Forms.TextBox txtMatKhau;
        public System.Windows.Forms.Button btnToggleMatKhau;
        public System.Windows.Forms.CheckBox chkGhiNho;
        public System.Windows.Forms.LinkLabel lnkQuenMatKhau;
        public System.Windows.Forms.Label lblThongBaoLoi;
        public System.Windows.Forms.Button btnDangNhap;
        public System.Windows.Forms.LinkLabel lnkDangKy;
        public System.Windows.Forms.Button btnThoat;
    }
}
