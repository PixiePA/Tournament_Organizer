namespace Tournament_Tracker
{
    public static class DatabaseManager
    {
        public static TOContext context = new TOContext();

        public static void Save()
        {
            context.SaveChanges();
        }
    }
}
