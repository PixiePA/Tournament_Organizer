using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    public class Bracket
    {
        private int bracketID;

        private int currentRound = 1;

        private int tournamentID;

        private bool hasLosersBracket;

        private bool isFinished;

        private bool isFinals;

        public int BracketID { get => bracketID; set => bracketID = value; }

        public int CurrentRound { get => currentRound; set => currentRound = value; }

        public bool HasLosersBracket { get => hasLosersBracket; set => hasLosersBracket = value; }

        public bool IsFinished { get => isFinished; set => isFinished = value; }

        public bool IsFinals { get => isFinals; set => isFinals = value; }

        [ForeignKey(nameof(Tournament))]
        [Required]
        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        public Tournament Tournament { get; set; }

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

        public LosersBracket LosersBracket
        {
            get
            {
                IEnumerable<LosersBracket> LosersBracket =
                    from Brackets in DatabaseManager.context.LosersBrackets
                    where Brackets.WinnersBracketID == BracketID
                    select Brackets;
                if (LosersBracket.Any())
                {
                    return LosersBracket.First();
                }
                else
                {
                    throw new InvalidOperationException("No losers bracket found");
                }
            }
        }

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

        public bool SeedBracket()
        {
            throw new NotImplementedException();
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

                if (!isFinals)
                {
                    CurrentRound++;
                    //More than one competitor remaining
                    if (Winners.Count() != 1)
                    {
                        int i = 0;
                        for (i = 0; i + 1 < Winners.Count; i = 2)
                        {
                            CreateNewMatch(Winners[i], Winners[i + 1], i / 2);
                        }
                        if (i < Winners.Count)
                        {
                            new Match(Winners.Last(), (i + 2 / 2), currentRound);
                        }

                        //If there is no losers bracket, finals happen when 2 players remaining
                        if (!hasLosersBracket && Winners.Count == 2)
                        {
                            isFinals = true;
                        }

                        //Add losers of current round to losers bracket
                        if (HasLosersBracket)
                        {

                        }
                    }
                    //Losers bracket winner vs winner's bracket winner match still needs to be run
                    else if (HasLosersBracket)
                    {
                        //Get winner of losers bracket and arrange fight with winners bracket champion
                        IEnumerable<LosersBracket> losersBrackets =
                            from losersbracket in DatabaseManager.context.LosersBrackets
                            where losersbracket.WinnersBracketID == bracketID
                            select losersbracket;

                        CreateNewMatch(Winner, losersBrackets.First().Winner, 1);
                        isFinals = true;
                    }
                    else
                    {
                        throw new Exception("I don't know how you got here. This is never meant to happen. There's some logic bug here.");
                    }

                    
                }// End of finals check

                else
                {
                    isFinished = true;
                }


            }// End of finished check

            DatabaseManager.UpdateEntity(this);

            return isFinished;
        }
    }
}
