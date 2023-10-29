using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    [PrimaryKey(nameof(TeamID), nameof(TournamentID))]
    public class TournamentRegistration
    {
        private int teamID;
        private int tournamentID;
        private int wins = 0;

        public int Wins { get => wins; set => wins = value; }

        [ForeignKey(nameof(Team))]
        [Required]
        public int TeamID { get => teamID; set => teamID = value; }


        [ForeignKey(nameof(Tournament))]
        [Required]
        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        public Tournament Tournament { get; set; }

        public Team Team { get; set; }
    }
}
