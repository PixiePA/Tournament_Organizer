using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    public class Bracket
    {
        private int bracketID;

        private int currentRound = 0;

        private int tournamentID;

        private bool hasLosersBracket;

        private bool isFinished = false;

        private bool isFinals = false;

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

        public void SeedBracket(List<TournamentRegistration> Competitors)
        {
            List<TournamentRegistration> sortedCompetitors =
                (from competitor in Competitors
                orderby competitor.Team.AveragePoints
                select competitor).ToList();


            int halfSize = sortedCompetitors.Count() / 2;

            List<TournamentRegistration> SeededTeams = new List<TournamentRegistration>();

            for (int i = sortedCompetitors.Count() % 2 == 0 ? 0 : 1 ; i + halfSize < sortedCompetitors.Count(); i++)
            {
                SeededTeams.Add(sortedCompetitors[i]);
                SeededTeams.Add(sortedCompetitors[i + halfSize]);
            }

            if (sortedCompetitors.Count() % 2 != 0)
            {
                SeededTeams.Add(sortedCompetitors.First());
            }

            SetupNextRound(SeededTeams);

            DatabaseManager.UpdateEntity(this);
        }

        public void AddLosersBracket()
        {
            if (hasLosersBracket)
            {
                throw new InvalidOperationException("Already has a losers bracket");
            }

            LosersBracket newLosersBracket = new LosersBracket() { TournamentID = this.tournamentID, WinnersBracket = this};

            DatabaseManager.context.LosersBrackets.Add(newLosersBracket);
            DatabaseManager.Save();

            hasLosersBracket = true;

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

        public void SetupNextRound(List<TournamentRegistration> Competitors)
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

                    //If there is no losers bracket, finals happen when 2 players remaining
                    if (!hasLosersBracket && Competitors.Count == 2)
                    {
                        isFinals = true;
                    }

                    //Add losers of current round to losers bracket
                    if (HasLosersBracket)
                    {
                        LosersBracket.BeginNextRound();
                    }
                }
                //Losers bracket winner vs winner's bracket winner match still needs to be run
                else if (HasLosersBracket)
                {
                    //Get winner of losers bracket and arrange fight with Competitors bracket champion 
                    if (LosersBracket.isFinished)
                    {
                        CreateNewMatch(Winner, LosersBracket.Winner, 1);
                        isFinals = true;
                    }
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
        }
    }


}
