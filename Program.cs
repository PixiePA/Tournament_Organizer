namespace Tournament_Tracker
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseManager.context.Database.EnsureCreated();

            //This is test code to test if composite primary keys are working
            /*TeamRegistration newRegistration = new TeamRegistration() { PlayerID = 4, TeamID = 2 };

            DatabaseManager.context.TeamRegistrations.Add(newRegistration);*/

            //This is test code to test if team registration works properly
            /*Player newPlayer = new Player("testPlayer", 1, 1, "testEmail");
            Team newTeam = new Team() { Name = "testTeam" };

            newTeam.RegisterToTeam(newPlayer);*/

            DatabaseManager.Save();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}