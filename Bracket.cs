using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    public class Bracket
    {
        private int bracketID;

        private int currentRound = 1;

        public int BracketID { get => bracketID; set => bracketID = value; }

        public int CurrentRound { get => currentRound; set => currentRound = value; }

        [NotMapped]
        public List<Match> Matches
        {
            get
            {
                IEnumerable<Match> matches =
                    from match in DatabaseManager.context.Matches
                    where match.BracketID == bracketID
                    select match;
                return matches.ToList();
            }
        }

        public List<Match> AllMatchesInRound(int round)
        {
            IEnumerable<Match> matches =
                    from match in Matches
                    where match.RoundNumber == round
                    select match;
            return matches.ToList();
        }

        public bool AllMatchesFinished()
        {
            foreach (Match match in Matches)
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
