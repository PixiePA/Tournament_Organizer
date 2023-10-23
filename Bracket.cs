using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class Bracket
    {
        private int bracketID;
        private List<int> tournamentRegistrations = new List<int>();
        private List<int> matches = new List<int>();

        public List<Match> GetMatches()
        {
            throw new NotImplementedException();
        }

        public bool AllMatchesFinished()
        {
            foreach (Match match in GetMatches())
            {
                if (match.IsMatchOver())
                {
                    return true;
                }
            }

            return false;
        }

        public bool SeedBracket()
        {
            throw new NotImplementedException();
        }
    }
}
