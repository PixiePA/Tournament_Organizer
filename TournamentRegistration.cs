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

        [ForeignKey (nameof(Team))]
        [Required]
        public int TeamID { get => teamID; set => teamID = value; }

        [ForeignKey (nameof (Tournament))]
        [Required]
        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        [ForeignKey (nameof(BracketID))]
        public int BracketID { get => bracketID; set => bracketID = value; }

        public Player Team { get; set; }

        public Tournament Tournament { get; set; }

        public Bracket Bracket { get; set; }
        public int Wins { get => wins; set => wins = value; }
    }
}
