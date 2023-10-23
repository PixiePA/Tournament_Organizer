using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public int PlayerID { get => playerID; set => playerID = value; }
        public int TournamentID { get => tournamentID; set => tournamentID = value; }
    }
}
