using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    [PrimaryKey(nameof(TournamentID))]
    internal class Tournament
    {
        private int tournamentID;
        private string tournamentName = "";

        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        [Required]
        public string TournamentName { get => tournamentName; set => tournamentName = value; }

        [NotMapped]
        public List<TournamentRegistration> Placements 
        {
            get
            {
                IEnumerable<TournamentRegistration> sortedRegistrations =
                    from registrations in AllRegistrants
                    orderby registrations.Wins
                    select registrations;
                return sortedRegistrations.ToList();
            }
        }

        [NotMapped]
        public List<TournamentRegistration> AllRegistrants
        {
            get
            {
                IEnumerable<TournamentRegistration> allRegistrations =
                    from registrations in DatabaseManager.context.TournamentRegistrations
                    where registrations.TournamentID == tournamentID
                    orderby registrations.TeamID
                    select registrations;
                return allRegistrations.ToList();
            }
        }
        //abstract public TournamentType TournamentType { get; }

        public int Winner
        {
            get
            {
                throw new NotImplementedException();
            }

        }

        //public abstract void PlaySets();
    }
}
