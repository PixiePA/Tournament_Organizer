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
            TOContext context = new TOContext();

            context.Database.EnsureCreated();

            context.Players.Add(new Player("name", 0, 0, "email"));

            context.SaveChanges();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}