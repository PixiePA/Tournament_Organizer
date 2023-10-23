using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    [PrimaryKey (nameof(PlayerID), nameof(MatchID))]
    internal class MatchRegistration
    {
        private int playerID;
        private int matchID;

        public int PlayerID { get => playerID; set => playerID = value; }
        public int MatchID { get => matchID; set => matchID = value; }
    }
}
