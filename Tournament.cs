using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class Tournament
    {
        private int tournamentID;
        private string tournamentName = "";
        private List<int> placements = new List<int>();
        private List<int> brackets = new List<int>();
        private TournamentType tournamentType;

        public int TournamentID { get => tournamentID; set => tournamentID = value; }
        [Required]
        public string TournamentName { get => tournamentName; set => tournamentName = value; }
        public int[] Placements { get => placements.ToArray(); set => placements = new List<int>(value); }
        public int[] Brackets { get => brackets.ToArray(); set => brackets = new List<int>(value); }
        //abstract public TournamentType TournamentType { get; }

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

        //public abstract void PlaySets();
    }

    enum TournamentType
    {
        SingleElims,
        DoubleElims
    }
}
