using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    [PrimaryKey (nameof(TeamID), nameof(TournamentID))]
    internal class TournamentRegistration
    {
        private int teamID;
        private int tournamentID;
        private int bracketID;
        private int wins;

        [Required]
        [ForeignKey (nameof(Team))]
        public int TeamID { get => teamID; set => teamID = value; }


        [ForeignKey (nameof(Tournament))]
        [Required]
        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        [ForeignKey (nameof(Bracket))]
        public int BracketID { get => bracketID; set => bracketID = value; }

        public Tournament Tournament { get; set; }

        public Team Team { get; set; }

        public Bracket Bracket { get; set; }

        public int Wins { get => wins; set => wins = value; }
    }
}
