using QLBH_QUANLYBANHANG.form;

namespace QLBH_QUANLYBANHANG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoignForm());

        }
    }
}