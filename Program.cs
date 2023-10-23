using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;

namespace Tournament_Tracker
{
    internal static class Program
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

            DatabaseManager.Save();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}