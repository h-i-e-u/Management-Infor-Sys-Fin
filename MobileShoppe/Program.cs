namespace MobileShoppe
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
            ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // show splash screen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();

           

            // main app
            Application.Run(new UserLogin());
        }
    }
}