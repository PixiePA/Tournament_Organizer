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
    [PrimaryKey (nameof(PlayerID), nameof(TournamentID))]
    internal class TournamentRegistration
    {
        private int playerID;
        private int tournamentID;

        [ForeignKey (nameof (Player))]
        [Required]
        public int PlayerID { get => playerID; set => playerID = value; }

        [ForeignKey (nameof (Tournament))]
        [Required]
        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        public Player Player { get; set; }

        public Tournament Tournament { get; set; }
    }
}
