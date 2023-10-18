using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class TeamRegistration
    {
        private int teamRegistrationID;
        private int playerID;
        private int teamID;

        public int TeamRegistrationID { get => teamRegistrationID; set => teamRegistrationID = value; }
        public int PlayerID { get => playerID; set => playerID = value; }
        public int TeamID { get => teamID; set => teamID = value; }
    }
}
