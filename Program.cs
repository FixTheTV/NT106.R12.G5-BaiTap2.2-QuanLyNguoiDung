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

            

            Application.Run(new Form1());
        }
    }
}