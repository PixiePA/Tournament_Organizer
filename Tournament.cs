using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class Tournament
    {
        private int tournamentID;
        private string tournamentName = "";
        private List<Player> placements = new List<Player>();

        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        public string TournamentName { get => tournamentName; set => tournamentName = value; }
        internal List<Player> Placements { get => placements; set => placements = value; }
        public Player Winner
        {
            get
            {
                if (placements.Count > 0)
                {
                    return placements[0];
                }
                else
                {
                    return null;
                }
            }

        }
    }
}
