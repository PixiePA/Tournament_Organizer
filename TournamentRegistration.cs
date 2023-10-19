using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class TournamentRegistration
    {
        private int tournamentRegistrationID;
        private int playerID;
        private int tournamentID;

        public int TournamentRegistrationID { get => tournamentRegistrationID; set => tournamentRegistrationID = value; }
        public int PlayerID { get => playerID; set => playerID = value; }
        public int TournamentID { get => tournamentID; set => tournamentID = value; }
    }
}
