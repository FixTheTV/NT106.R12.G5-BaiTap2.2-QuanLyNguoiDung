namespace QuanLyNguoiDungWinForms
{
    partial class RegisterForm
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
            lblHeaderTen = new Label();
            txtTenDangNhap = new TextBox();
            lblSubTen = new Label();
            lblLoiTenDangNhap = new Label();
            lblHeaderEmail = new Label();
            txtEmail = new TextBox();
            lblSubEmail = new Label();
            lblLoiEmail = new Label();
            lblHeaderSDT = new Label();
            txtSoDienThoai = new TextBox();
            lblSubSDT = new Label();
            lblLoiSoDienThoai = new Label();
            lblHeaderTuoi = new Label();
            txtDoTuoi = new TextBox();
            lblSubTuoi = new Label();
            lblLoiDoTuoi = new Label();
            lblHeaderMK = new Label();
            pnlMK = new Panel();
            txtMatKhau = new TextBox();
            btnToggleMatKhau = new Button();
            lblSubMK = new Label();
            lblLoiMatKhau = new Label();
            lblHeaderXacNhan = new Label();
            pnlXacNhan = new Panel();
            txtXacNhanMatKhau = new TextBox();
            btnToggleXacNhan = new Button();
            lblSubXacNhan = new Label();
            lblLoiXacNhanMatKhau = new Label();
            lblHeaderHoTen = new Label();
            txtHoTen = new TextBox();
            lblSubHoTen = new Label();
            lblLoiHoTen = new Label();
            lblThongBaoChung = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            cardPanel.SuspendLayout();
            pnlMK.SuspendLayout();
            pnlXacNhan.SuspendLayout();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.AutoScroll = true;
            cardPanel.BackColor = Color.White;
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Controls.Add(lblTieuDe);
            cardPanel.Controls.Add(lblHeaderTen);
            cardPanel.Controls.Add(txtTenDangNhap);
            cardPanel.Controls.Add(lblSubTen);
            cardPanel.Controls.Add(lblLoiTenDangNhap);
            cardPanel.Controls.Add(lblHeaderEmail);
            cardPanel.Controls.Add(txtEmail);
            cardPanel.Controls.Add(lblSubEmail);
            cardPanel.Controls.Add(lblLoiEmail);
            cardPanel.Controls.Add(lblHeaderSDT);
            cardPanel.Controls.Add(txtSoDienThoai);
            cardPanel.Controls.Add(lblSubSDT);
            cardPanel.Controls.Add(lblLoiSoDienThoai);
            cardPanel.Controls.Add(lblHeaderTuoi);
            cardPanel.Controls.Add(txtDoTuoi);
            cardPanel.Controls.Add(lblSubTuoi);
            cardPanel.Controls.Add(lblLoiDoTuoi);
            cardPanel.Controls.Add(lblHeaderMK);
            cardPanel.Controls.Add(pnlMK);
            cardPanel.Controls.Add(lblSubMK);
            cardPanel.Controls.Add(lblLoiMatKhau);
            cardPanel.Controls.Add(lblHeaderXacNhan);
            cardPanel.Controls.Add(pnlXacNhan);
            cardPanel.Controls.Add(lblSubXacNhan);
            cardPanel.Controls.Add(lblLoiXacNhanMatKhau);
            cardPanel.Controls.Add(lblHeaderHoTen);
            cardPanel.Controls.Add(txtHoTen);
            cardPanel.Controls.Add(lblSubHoTen);
            cardPanel.Controls.Add(lblLoiHoTen);
            cardPanel.Controls.Add(lblThongBaoChung);
            cardPanel.Controls.Add(btnDangKy);
            cardPanel.Controls.Add(btnHuy);
            cardPanel.Location = new Point(28, 20);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(510, 755);
            cardPanel.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(30, 30, 30);
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(460, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG KÝ TÀI KHOẢN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTen
            // 
            lblHeaderTen.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderTen.ForeColor = Color.FromArgb(40, 40, 40);
            lblHeaderTen.Location = new Point(30, 60);
            lblHeaderTen.Name = "lblHeaderTen";
            lblHeaderTen.Size = new Size(440, 20);
            lblHeaderTen.TabIndex = 1;
            lblHeaderTen.Text = "Tên đăng nhập (*)";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(30, 82);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(440, 30);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblSubTen
            // 
            lblSubTen.Font = new Font("Segoe UI", 8F);
            lblSubTen.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubTen.Location = new Point(30, 114);
            lblSubTen.Name = "lblSubTen";
            lblSubTen.Size = new Size(440, 36);
            lblSubTen.TabIndex = 2;
            lblSubTen.Text = "* 3 - 20 ký tự (chữ cái, chữ số, gạch dưới; không chứa ký tự đặc biệt)";
            // 
            // lblLoiTenDangNhap
            // 
            lblLoiTenDangNhap.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLoiTenDangNhap.ForeColor = Color.Red;
            lblLoiTenDangNhap.Location = new Point(30, 132);
            lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            lblLoiTenDangNhap.Size = new Size(440, 18);
            lblLoiTenDangNhap.TabIndex = 3;
            // 
            // lblHeaderEmail
            // 
            lblHeaderEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderEmail.ForeColor = Color.FromArgb(40, 40, 40);
            lblHeaderEmail.Location = new Point(30, 154);
            lblHeaderEmail.Name = "lblHeaderEmail";
            lblHeaderEmail.Size = new Size(440, 20);
            lblHeaderEmail.TabIndex = 4;
            lblHeaderEmail.Text = "Email (*)";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(30, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(440, 30);
            txtEmail.TabIndex = 1;
            // 
            // lblSubEmail
            // 
            lblSubEmail.Font = new Font("Segoe UI", 8F);
            lblSubEmail.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubEmail.Location = new Point(30, 208);
            lblSubEmail.Name = "lblSubEmail";
            lblSubEmail.Size = new Size(440, 36);
            lblSubEmail.TabIndex = 5;
            lblSubEmail.Text = "* Định dạng: ten@mien.com";
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLoiEmail.ForeColor = Color.Red;
            lblLoiEmail.Location = new Point(30, 226);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(440, 18);
            lblLoiEmail.TabIndex = 6;
            // 
            // lblHeaderSDT
            // 
            lblHeaderSDT.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderSDT.ForeColor = Color.FromArgb(40, 40, 40);
            lblHeaderSDT.Location = new Point(30, 248);
            lblHeaderSDT.Name = "lblHeaderSDT";
            lblHeaderSDT.Size = new Size(440, 20);
            lblHeaderSDT.TabIndex = 7;
            lblHeaderSDT.Text = "Số điện thoại (*)";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new Point(30, 270);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(440, 30);
            txtSoDienThoai.TabIndex = 2;
            // 
            // lblSubSDT
            // 
            lblSubSDT.Font = new Font("Segoe UI", 8F);
            lblSubSDT.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubSDT.Location = new Point(30, 302);
            lblSubSDT.Name = "lblSubSDT";
            lblSubSDT.Size = new Size(440, 36);
            lblSubSDT.TabIndex = 8;
            lblSubSDT.Text = "* Cú pháp: Mã quốc gia (+84) + Số điện thoại";
            // 
            // lblLoiSoDienThoai
            // 
            lblLoiSoDienThoai.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLoiSoDienThoai.ForeColor = Color.Red;
            lblLoiSoDienThoai.Location = new Point(30, 320);
            lblLoiSoDienThoai.Name = "lblLoiSoDienThoai";
            lblLoiSoDienThoai.Size = new Size(440, 18);
            lblLoiSoDienThoai.TabIndex = 9;
            // 
            // lblHeaderTuoi
            // 
            lblHeaderTuoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderTuoi.ForeColor = Color.FromArgb(40, 40, 40);
            lblHeaderTuoi.Location = new Point(30, 342);
            lblHeaderTuoi.Name = "lblHeaderTuoi";
            lblHeaderTuoi.Size = new Size(440, 20);
            lblHeaderTuoi.TabIndex = 10;
            lblHeaderTuoi.Text = "Độ tuổi (*)";
            // 
            // txtDoTuoi
            // 
            txtDoTuoi.Font = new Font("Segoe UI", 10F);
            txtDoTuoi.Location = new Point(30, 364);
            txtDoTuoi.Name = "txtDoTuoi";
            txtDoTuoi.Size = new Size(440, 30);
            txtDoTuoi.TabIndex = 3;
            // 
            // lblSubTuoi
            // 
            lblSubTuoi.Font = new Font("Segoe UI", 8F);
            lblSubTuoi.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubTuoi.Location = new Point(30, 396);
            lblSubTuoi.Name = "lblSubTuoi";
            lblSubTuoi.Size = new Size(440, 16);
            lblSubTuoi.TabIndex = 11;
            lblSubTuoi.Text = "* Yêu cầu từ 16 tuổi trở lên";
            // 
            // lblLoiDoTuoi
            // 
            lblLoiDoTuoi.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLoiDoTuoi.ForeColor = Color.Red;
            lblLoiDoTuoi.Location = new Point(30, 414);
            lblLoiDoTuoi.Name = "lblLoiDoTuoi";
            lblLoiDoTuoi.Size = new Size(440, 18);
            lblLoiDoTuoi.TabIndex = 12;
            // 
            // lblHeaderMK
            // 
            lblHeaderMK.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderMK.ForeColor = Color.FromArgb(40, 40, 40);
            lblHeaderMK.Location = new Point(30, 436);
            lblHeaderMK.Name = "lblHeaderMK";
            lblHeaderMK.Size = new Size(440, 20);
            lblHeaderMK.TabIndex = 13;
            lblHeaderMK.Text = "Mật khẩu (*)";
            // 
            // pnlMK
            // 
            pnlMK.BorderStyle = BorderStyle.FixedSingle;
            pnlMK.Controls.Add(txtMatKhau);
            pnlMK.Controls.Add(btnToggleMatKhau);
            pnlMK.Location = new Point(30, 458);
            pnlMK.Name = "pnlMK";
            pnlMK.Size = new Size(440, 30);
            pnlMK.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(2, 3);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(395, 23);
            txtMatKhau.TabIndex = 0;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnToggleMatKhau
            // 
            btnToggleMatKhau.Cursor = Cursors.Hand;
            btnToggleMatKhau.FlatAppearance.BorderSize = 0;
            btnToggleMatKhau.FlatStyle = FlatStyle.Flat;
            btnToggleMatKhau.Font = new Font("Segoe UI", 9F);
            btnToggleMatKhau.Location = new Point(400, 1);
            btnToggleMatKhau.Name = "btnToggleMatKhau";
            btnToggleMatKhau.Size = new Size(36, 26);
            btnToggleMatKhau.TabIndex = 1;
            btnToggleMatKhau.Text = "👁";
            btnToggleMatKhau.UseVisualStyleBackColor = true;
            btnToggleMatKhau.Click += BtnToggleMatKhau_Click;
            // 
            // lblSubMK
            // 
            lblSubMK.Font = new Font("Segoe UI", 8F);
            lblSubMK.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubMK.Location = new Point(30, 492);
            lblSubMK.Name = "lblSubMK";
            lblSubMK.Size = new Size(440, 40);
            lblSubMK.TabIndex = 14;
            lblSubMK.Text = "* Tối thiểu 8 ký tự (gồm chữ cái, chữ số, ký tự đặc biệt)";
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(33, 514);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(440, 18);
            lblLoiMatKhau.TabIndex = 15;
            // 
            // lblHeaderXacNhan
            // 
            lblHeaderXacNhan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderXacNhan.ForeColor = Color.FromArgb(40, 40, 40);
            lblHeaderXacNhan.Location = new Point(30, 532);
            lblHeaderXacNhan.Name = "lblHeaderXacNhan";
            lblHeaderXacNhan.Size = new Size(440, 20);
            lblHeaderXacNhan.TabIndex = 16;
            lblHeaderXacNhan.Text = "Xác nhận mật khẩu (*)";
            // 
            // pnlXacNhan
            // 
            pnlXacNhan.BorderStyle = BorderStyle.FixedSingle;
            pnlXacNhan.Controls.Add(txtXacNhanMatKhau);
            pnlXacNhan.Controls.Add(btnToggleXacNhan);
            pnlXacNhan.Location = new Point(30, 554);
            pnlXacNhan.Name = "pnlXacNhan";
            pnlXacNhan.Size = new Size(440, 30);
            pnlXacNhan.TabIndex = 5;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.BorderStyle = BorderStyle.None;
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 10F);
            txtXacNhanMatKhau.Location = new Point(2, 3);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(395, 23);
            txtXacNhanMatKhau.TabIndex = 0;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // btnToggleXacNhan
            // 
            btnToggleXacNhan.Cursor = Cursors.Hand;
            btnToggleXacNhan.FlatAppearance.BorderSize = 0;
            btnToggleXacNhan.FlatStyle = FlatStyle.Flat;
            btnToggleXacNhan.Font = new Font("Segoe UI", 9F);
            btnToggleXacNhan.Location = new Point(400, 1);
            btnToggleXacNhan.Name = "btnToggleXacNhan";
            btnToggleXacNhan.Size = new Size(36, 26);
            btnToggleXacNhan.TabIndex = 1;
            btnToggleXacNhan.Text = "👁";
            btnToggleXacNhan.UseVisualStyleBackColor = true;
            btnToggleXacNhan.Click += BtnToggleXacNhan_Click;
            // 
            // lblSubXacNhan
            // 
            lblSubXacNhan.Font = new Font("Segoe UI", 8F);
            lblSubXacNhan.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubXacNhan.Location = new Point(30, 588);
            lblSubXacNhan.Name = "lblSubXacNhan";
            lblSubXacNhan.Size = new Size(440, 36);
            lblSubXacNhan.TabIndex = 17;
            lblSubXacNhan.Text = "* Phải trùng khớp với Mật khẩu đã nhập";
            // 
            // lblLoiXacNhanMatKhau
            // 
            lblLoiXacNhanMatKhau.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLoiXacNhanMatKhau.ForeColor = Color.Red;
            lblLoiXacNhanMatKhau.Location = new Point(30, 606);
            lblLoiXacNhanMatKhau.Name = "lblLoiXacNhanMatKhau";
            lblLoiXacNhanMatKhau.Size = new Size(440, 18);
            lblLoiXacNhanMatKhau.TabIndex = 18;
            // 
            // lblHeaderHoTen
            // 
            lblHeaderHoTen.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderHoTen.ForeColor = Color.FromArgb(40, 40, 40);
            lblHeaderHoTen.Location = new Point(30, 628);
            lblHeaderHoTen.Name = "lblHeaderHoTen";
            lblHeaderHoTen.Size = new Size(440, 20);
            lblHeaderHoTen.TabIndex = 19;
            lblHeaderHoTen.Text = "Họ và tên (*)";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(30, 650);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(440, 30);
            txtHoTen.TabIndex = 6;
            // 
            // lblSubHoTen
            // 
            lblSubHoTen.Font = new Font("Segoe UI", 8F);
            lblSubHoTen.ForeColor = Color.FromArgb(120, 120, 120);
            lblSubHoTen.Location = new Point(30, 682);
            lblSubHoTen.Name = "lblSubHoTen";
            lblSubHoTen.Size = new Size(440, 36);
            lblSubHoTen.TabIndex = 20;
            lblSubHoTen.Text = "* 2 - 50 ký tự (cho phép dấu tiếng Việt và khoảng trắng)";
            // 
            // lblLoiHoTen
            // 
            lblLoiHoTen.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLoiHoTen.ForeColor = Color.Red;
            lblLoiHoTen.Location = new Point(30, 700);
            lblLoiHoTen.Name = "lblLoiHoTen";
            lblLoiHoTen.Size = new Size(440, 18);
            lblLoiHoTen.TabIndex = 21;
            // 
            // lblThongBaoChung
            // 
            lblThongBaoChung.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThongBaoChung.ForeColor = Color.Red;
            lblThongBaoChung.Location = new Point(30, 722);
            lblThongBaoChung.Name = "lblThongBaoChung";
            lblThongBaoChung.Size = new Size(440, 24);
            lblThongBaoChung.TabIndex = 7;
            lblThongBaoChung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(0, 132, 255);
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(80, 755);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(160, 42);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += BtnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(230, 230, 230);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnHuy.ForeColor = Color.FromArgb(60, 60, 60);
            btnHuy.Location = new Point(260, 755);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(160, 42);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "HỦY / THOÁT";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += BtnHuy_Click;
            // 
            // RegisterForm
            // 
            AcceptButton = btnDangKy;
            BackColor = Color.FromArgb(245, 247, 250);
            CancelButton = btnHuy;
            ClientSize = new Size(564, 821);
            Controls.Add(cardPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            pnlMK.ResumeLayout(false);
            pnlMK.PerformLayout();
            pnlXacNhan.ResumeLayout(false);
            pnlXacNhan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel cardPanel;
        public System.Windows.Forms.Label lblTieuDe;
        public System.Windows.Forms.Label lblHeaderTen;
        public System.Windows.Forms.TextBox txtTenDangNhap;
        public System.Windows.Forms.Label lblSubTen;
        public System.Windows.Forms.Label lblLoiTenDangNhap;

        public System.Windows.Forms.Label lblHeaderEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label lblSubEmail;
        public System.Windows.Forms.Label lblLoiEmail;

        public System.Windows.Forms.Label lblHeaderSDT;
        public System.Windows.Forms.TextBox txtSoDienThoai;
        public System.Windows.Forms.Label lblSubSDT;
        public System.Windows.Forms.Label lblLoiSoDienThoai;

        public System.Windows.Forms.Label lblHeaderTuoi;
        public System.Windows.Forms.TextBox txtDoTuoi;
        public System.Windows.Forms.Label lblSubTuoi;
        public System.Windows.Forms.Label lblLoiDoTuoi;

        public System.Windows.Forms.Label lblHeaderMK;
        public System.Windows.Forms.Panel pnlMK;
        public System.Windows.Forms.TextBox txtMatKhau;
        public System.Windows.Forms.Button btnToggleMatKhau;
        public System.Windows.Forms.Label lblSubMK;
        public System.Windows.Forms.Label lblLoiMatKhau;

        public System.Windows.Forms.Label lblHeaderXacNhan;
        public System.Windows.Forms.Panel pnlXacNhan;
        public System.Windows.Forms.TextBox txtXacNhanMatKhau;
        public System.Windows.Forms.Button btnToggleXacNhan;
        public System.Windows.Forms.Label lblSubXacNhan;
        public System.Windows.Forms.Label lblLoiXacNhanMatKhau;

        public System.Windows.Forms.Label lblHeaderHoTen;
        public System.Windows.Forms.TextBox txtHoTen;
        public System.Windows.Forms.Label lblSubHoTen;
        public System.Windows.Forms.Label lblLoiHoTen;

        public System.Windows.Forms.Label lblThongBaoChung;
        public System.Windows.Forms.Button btnDangKy;
        public System.Windows.Forms.Button btnHuy;
    }
}
