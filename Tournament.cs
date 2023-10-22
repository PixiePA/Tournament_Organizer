using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal abstract class Tournament
    {
        private int tournamentID;
        private string tournamentName = "";
        private List<int> placements = new List<int>();
        private List<int> brackets = new List<int>();
        private TournamentType tournamentType;

        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        public string TournamentName { get => tournamentName; set => tournamentName = value; }
        public List<int> Placements { get => placements; set => placements = value; }
        public List<int> Brackets { get => brackets; set => brackets = value; }
        abstract public TournamentType TournamentType { get; }

        public int Winner
        {
            get
            {
                if (placements.Count > 0)
                {
                    return placements[0];
                }

                return -1;
            }

        }

        public abstract void PlaySets();
    }

    enum TournamentType
    {
        SingleElims,
        DoubleElims
    }
}
