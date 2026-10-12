namespace QuanLyNguoiDungWinForms
{
    partial class MainForm
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
            this.cardPanel = new System.Windows.Forms.Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblTitleTen = new System.Windows.Forms.Label();
            this.lblTenDangNhapVal = new System.Windows.Forms.Label();
            this.lblTitleEmail = new System.Windows.Forms.Label();
            this.lblEmailVal = new System.Windows.Forms.Label();
            this.lblTitleSDT = new System.Windows.Forms.Label();
            this.lblSoDienThoaiVal = new System.Windows.Forms.Label();
            this.lblTitleTuoi = new System.Windows.Forms.Label();
            this.lblDoTuoiVal = new System.Windows.Forms.Label();
            this.lblTitleNgayTao = new System.Windows.Forms.Label();
            this.lblNgayTaoVal = new System.Windows.Forms.Label();
            this.lblTitleLanCuoi = new System.Windows.Forms.Label();
            this.lblLanDangNhapCuoiVal = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();

            this.cardPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.White;
            this.cardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPanel.Controls.Add(this.lblXinChao);
            this.cardPanel.Controls.Add(this.lblDivider);
            this.cardPanel.Controls.Add(this.lblTitleTen);
            this.cardPanel.Controls.Add(this.lblTenDangNhapVal);
            this.cardPanel.Controls.Add(this.lblTitleEmail);
            this.cardPanel.Controls.Add(this.lblEmailVal);
            this.cardPanel.Controls.Add(this.lblTitleSDT);
            this.cardPanel.Controls.Add(this.lblSoDienThoaiVal);
            this.cardPanel.Controls.Add(this.lblTitleTuoi);
            this.cardPanel.Controls.Add(this.lblDoTuoiVal);
            this.cardPanel.Controls.Add(this.lblTitleNgayTao);
            this.cardPanel.Controls.Add(this.lblNgayTaoVal);
            this.cardPanel.Controls.Add(this.lblTitleLanCuoi);
            this.cardPanel.Controls.Add(this.lblLanDangNhapCuoiVal);
            this.cardPanel.Controls.Add(this.btnDangXuat);
            this.cardPanel.Location = new System.Drawing.Point(32, 22);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(440, 390);
            this.cardPanel.TabIndex = 0;

            // 
            // lblXinChao
            // 
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(0, 122, 255);
            this.lblXinChao.Location = new System.Drawing.Point(20, 20);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(400, 35);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào, Người dùng!";

            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblDivider.Location = new System.Drawing.Point(20, 62);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(400, 2);
            this.lblDivider.TabIndex = 1;

            // 
            // lblTitleTen
            // 
            this.lblTitleTen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleTen.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTitleTen.Location = new System.Drawing.Point(20, 75);
            this.lblTitleTen.Name = "lblTitleTen";
            this.lblTitleTen.Size = new System.Drawing.Size(160, 22);
            this.lblTitleTen.TabIndex = 2;
            this.lblTitleTen.Text = "Tên đăng nhập:";

            // 
            // lblTenDangNhapVal
            // 
            this.lblTenDangNhapVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTenDangNhapVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblTenDangNhapVal.Location = new System.Drawing.Point(185, 75);
            this.lblTenDangNhapVal.Name = "lblTenDangNhapVal";
            this.lblTenDangNhapVal.Size = new System.Drawing.Size(235, 22);
            this.lblTenDangNhapVal.TabIndex = 3;

            // 
            // lblTitleEmail
            // 
            this.lblTitleEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleEmail.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTitleEmail.Location = new System.Drawing.Point(20, 113);
            this.lblTitleEmail.Name = "lblTitleEmail";
            this.lblTitleEmail.Size = new System.Drawing.Size(160, 22);
            this.lblTitleEmail.TabIndex = 4;
            this.lblTitleEmail.Text = "Email:";

            // 
            // lblEmailVal
            // 
            this.lblEmailVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmailVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblEmailVal.Location = new System.Drawing.Point(185, 113);
            this.lblEmailVal.Name = "lblEmailVal";
            this.lblEmailVal.Size = new System.Drawing.Size(235, 22);
            this.lblEmailVal.TabIndex = 5;

            // 
            // lblTitleSDT
            // 
            this.lblTitleSDT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleSDT.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTitleSDT.Location = new System.Drawing.Point(20, 151);
            this.lblTitleSDT.Name = "lblTitleSDT";
            this.lblTitleSDT.Size = new System.Drawing.Size(160, 22);
            this.lblTitleSDT.TabIndex = 6;
            this.lblTitleSDT.Text = "Số điện thoại:";

            // 
            // lblSoDienThoaiVal
            // 
            this.lblSoDienThoaiVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoDienThoaiVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblSoDienThoaiVal.Location = new System.Drawing.Point(185, 151);
            this.lblSoDienThoaiVal.Name = "lblSoDienThoaiVal";
            this.lblSoDienThoaiVal.Size = new System.Drawing.Size(235, 22);
            this.lblSoDienThoaiVal.TabIndex = 7;

            // 
            // lblTitleTuoi
            // 
            this.lblTitleTuoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleTuoi.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTitleTuoi.Location = new System.Drawing.Point(20, 189);
            this.lblTitleTuoi.Name = "lblTitleTuoi";
            this.lblTitleTuoi.Size = new System.Drawing.Size(160, 22);
            this.lblTitleTuoi.TabIndex = 8;
            this.lblTitleTuoi.Text = "Độ tuổi:";

            // 
            // lblDoTuoiVal
            // 
            this.lblDoTuoiVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDoTuoiVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblDoTuoiVal.Location = new System.Drawing.Point(185, 189);
            this.lblDoTuoiVal.Name = "lblDoTuoiVal";
            this.lblDoTuoiVal.Size = new System.Drawing.Size(235, 22);
            this.lblDoTuoiVal.TabIndex = 9;

            // 
            // lblTitleNgayTao
            // 
            this.lblTitleNgayTao.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleNgayTao.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTitleNgayTao.Location = new System.Drawing.Point(20, 227);
            this.lblTitleNgayTao.Name = "lblTitleNgayTao";
            this.lblTitleNgayTao.Size = new System.Drawing.Size(160, 22);
            this.lblTitleNgayTao.TabIndex = 10;
            this.lblTitleNgayTao.Text = "Ngày tạo tài khoản:";

            // 
            // lblNgayTaoVal
            // 
            this.lblNgayTaoVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayTaoVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblNgayTaoVal.Location = new System.Drawing.Point(185, 227);
            this.lblNgayTaoVal.Name = "lblNgayTaoVal";
            this.lblNgayTaoVal.Size = new System.Drawing.Size(235, 22);
            this.lblNgayTaoVal.TabIndex = 11;

            // 
            // lblTitleLanCuoi
            // 
            this.lblTitleLanCuoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleLanCuoi.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTitleLanCuoi.Location = new System.Drawing.Point(20, 265);
            this.lblTitleLanCuoi.Name = "lblTitleLanCuoi";
            this.lblTitleLanCuoi.Size = new System.Drawing.Size(160, 22);
            this.lblTitleLanCuoi.TabIndex = 12;
            this.lblTitleLanCuoi.Text = "Đăng nhập lần cuối:";

            // 
            // lblLanDangNhapCuoiVal
            // 
            this.lblLanDangNhapCuoiVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLanDangNhapCuoiVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblLanDangNhapCuoiVal.Location = new System.Drawing.Point(185, 265);
            this.lblLanDangNhapCuoiVal.Name = "lblLanDangNhapCuoiVal";
            this.lblLanDangNhapCuoiVal.Size = new System.Drawing.Size(235, 22);
            this.lblLanDangNhapCuoiVal.TabIndex = 13;

            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(280, 325);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(140, 42);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);

            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(504, 441);
            this.Controls.Add(this.cardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính - Hệ thống Quản lý Người dùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            this.cardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel cardPanel;
        public System.Windows.Forms.Label lblXinChao;
        public System.Windows.Forms.Label lblDivider;
        public System.Windows.Forms.Label lblTitleTen;
        public System.Windows.Forms.Label lblTenDangNhapVal;
        public System.Windows.Forms.Label lblTitleEmail;
        public System.Windows.Forms.Label lblEmailVal;
        public System.Windows.Forms.Label lblTitleSDT;
        public System.Windows.Forms.Label lblSoDienThoaiVal;
        public System.Windows.Forms.Label lblTitleTuoi;
        public System.Windows.Forms.Label lblDoTuoiVal;
        public System.Windows.Forms.Label lblTitleNgayTao;
        public System.Windows.Forms.Label lblNgayTaoVal;
        public System.Windows.Forms.Label lblTitleLanCuoi;
        public System.Windows.Forms.Label lblLanDangNhapCuoiVal;
        public System.Windows.Forms.Button btnDangXuat;
    }
}
