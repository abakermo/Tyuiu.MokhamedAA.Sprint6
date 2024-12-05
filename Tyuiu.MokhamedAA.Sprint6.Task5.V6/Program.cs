using Tyuiu.MokhamedAA.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task5.V6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}