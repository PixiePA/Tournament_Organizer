using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class Team
    {
        private int teamID;
        private string name = "";

        public int TeamID { get => teamID; set => teamID = value; }
        public string Name { get => name; set => name = value; }
    }
}
