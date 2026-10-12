using QuanLyNguoiDungWinForms;

namespace NT106.R12.G5_BaiTap2._2_QuanLyNguoiDung
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

            

            Application.Run(new LoginForm());
        }
    }
}
