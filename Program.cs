using Microsoft.EntityFrameworkCore;

namespace BookSalesSystem2._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();

            using (var context = new BookSalesSystemContext())
            {
                context.Database.Migrate();
            }

            Application.Run(new LoginForm());
        }
    }
}
