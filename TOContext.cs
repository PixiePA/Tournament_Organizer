using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tournament_Tracker
{
    internal class TOContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamRegistration> TeamRegistrations { get; set; }
        //public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentRegistration> TournamentRegistrations {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TournamentOrganizerDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tournament>()
                .Property(e => e.Brackets)
                .HasConversion(v => string.Join(',', v), v => Array.ConvertAll<string, int>(v.Split(',', StringSplitOptions.RemoveEmptyEntries), r => Convert.ToInt32(r)))
                ;
            modelBuilder.Entity<Tournament>()
                .Property(e => e.Placements)
                .HasConversion(v => string.Join(',', v), v => Array.ConvertAll<string, int>(v.Split(',', StringSplitOptions.RemoveEmptyEntries), r => Convert.ToInt32(r)))
                ;

            base.OnModelCreating(modelBuilder);
        }
    }
}

/*delegate (string v, out int[] test)
{
    

}*/
