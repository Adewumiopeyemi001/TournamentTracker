

namespace TrackerUI
{
    public static class Program
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
            Application.SetCompatibleTextRenderingDefault(false);


            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);
            //ApplicationConfiguration.Initialize();
            //Application.Run(new CreatePrizesForm());

            Application.Run(new CreateTeamForm());



            //Initialize the database connection

            //Application.Run(new CreatePrizesForm());
        }
    }
}