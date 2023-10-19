using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal static class DatabaseManager
    {
        public static TOContext context = new TOContext();

        public static void Save()
        {
            context.SaveChanges();
        }
    }
}
