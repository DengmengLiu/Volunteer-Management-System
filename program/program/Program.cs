

using program.Domain;
using program.Tools;
using User1;

namespace program
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            AdministratorFunction administratorFunction = new AdministratorFunction();
            administratorFunction.timer.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login loginform = new Login();

            Application.Run(loginform);



        }
    }
}