using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    public class Bracket
    {
        protected int bracketID;

        private int currentRound = 0;

        private int tournamentID;

        private bool isFinished = false;

        private bool isFinals = false;

        public int CurrentRound { get => currentRound; set => currentRound = value; }

        public bool IsFinished { get => isFinished; set => isFinished = value; }

        public bool IsFinals { get => isFinals; set => isFinals = value; }

        public int BracketID { get => bracketID; set => bracketID = value; }

        [ForeignKey(nameof(Tournament))]
        [Required]
        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        [Required]
        [ForeignKey(nameof(BracketID))]
        public ICollection<Match> Matches { get; set; }

        public Tournament Tournament { get; set; }

        public TournamentRegistration Winner
        {
            get
            {
                if (IsFinished)
                {
                    return AllWinnersInRound(CurrentRound).First();
                }

                throw new InvalidOperationException("Bracket is not yet resolved");
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

        public List<TournamentRegistration> AllWinnersInRound(int round)
        {
            List<TournamentRegistration> winners = new List<TournamentRegistration>();
            foreach (Match match in AllMatchesInRound(round))
            {
                winners.Add(DatabaseManager.context.TournamentRegistrations.Find(match.GetWinnerRegistrationID(), tournamentID));
            }
            return winners;
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

        public void CreateNewMatch(TournamentRegistration teamA, TournamentRegistration teamB, int roundPosition)
        {
            Match newMatch = new Match(teamA, teamB, roundPosition, CurrentRound);
        }

        public virtual bool BeginNextRound()
        {
            if (!isFinished)
            {
                
                List<TournamentRegistration> Winners = AllWinnersInRound(CurrentRound);
                foreach (TournamentRegistration winner in Winners)
                {
                    winner.Wins++;
                    DatabaseManager.UpdateEntity(winner);
                }

                SetupNextRound(Winners);


            }// End of finished check

            DatabaseManager.UpdateEntity(this);

            return isFinished;
        }

        public virtual void SetupNextRound(List<TournamentRegistration> Competitors)
        {
            if (!isFinals)
            {
                CurrentRound++;
                //More than one competitor remaining
                if (Competitors.Count() != 1)
                {
                    int i = 0;
                    for (i = 0; i + 1 < Competitors.Count; i = 2)
                    {
                        CreateNewMatch(Competitors[i], Competitors[i + 1], i / 2);
                    }
                    if (i < Competitors.Count)
                    {
                        new Match(Competitors.Last(), (i + 2 / 2), currentRound);
                    }

                    //Finals happen when 2 players remaining
                    if (Competitors.Count == 2)
                    {
                        isFinals = true;
                    }
                }
                //Losers bracket winner vs winner's bracket winner match still needs to be run
                else
                {
                    throw new Exception("I don't know how you got here. This is never meant to happen. There's some logic bug here.");
                }


            }// End of finals check

            else
            {
                isFinished = true;
            }
        }
    }


}
