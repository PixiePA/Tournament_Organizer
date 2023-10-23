using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    [PrimaryKey(nameof(PlayerID), nameof(TeamID))]
    internal class TeamRegistration
    {
        private int playerID;
        private int teamID;

        public int PlayerID { get => playerID; set => playerID = value; }
        public int TeamID { get => teamID; set => teamID = value; }
    }
}
