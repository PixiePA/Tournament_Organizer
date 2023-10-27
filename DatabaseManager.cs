namespace Tournament_Tracker
{
    internal static class DatabaseManager
    {
        public static TOContext context = new TOContext();

        public static void Save()
        {
            context.SaveChanges();
        }

        public static void UpdateEntity(object entity) 
        {
            DatabaseManager.context.Update(entity);
            DatabaseManager.Save();
        }
    }
}
