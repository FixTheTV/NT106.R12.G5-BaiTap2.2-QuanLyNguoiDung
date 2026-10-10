namespace NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung.Services
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Thử kết nối thực tế tới MySQL của XAMPP
            try
            {
                var db = new DatabaseService();
                // Gọi hàm để chạy lệnh conn.Open() thực tế
                db.CheckUsernameExists("test_connection");
                MessageBox.Show("Đã kết nối thành công tới Database MySQL trên XAMPP!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa kết nối được! Lỗi: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new Form1());
        }
    }
}