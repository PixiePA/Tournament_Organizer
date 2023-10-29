using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    public class WinnersBracket : Bracket

    {
        private bool hasLosersBracket;

        public int WinnersBracketID { get => bracketID; set => bracketID = value; }

        public bool HasLosersBracket { get => hasLosersBracket; set => hasLosersBracket = value; }

        [NotMapped]
        public Bracket LosersBracket
        {
            get
            {
                IEnumerable<Bracket> LosersBracket =
                    from Brackets in DatabaseManager.context.LosersBrackets
                    where Brackets.BracketID == this.BracketID
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

        public void AddLosersBracket()
        {
            if (HasLosersBracket)
            {
                throw new InvalidOperationException("Already has a losers bracket");
            }

            LosersBracket newLosersBracket = new LosersBracket() { TournamentID = this.TournamentID, WinnersBracket = this };

            DatabaseManager.context.LosersBrackets.Add(newLosersBracket);
            DatabaseManager.Save();

            HasLosersBracket = true;
        }

        public void SeedBracket(List<TournamentRegistration> Competitors)
        {
            List<TournamentRegistration> sortedCompetitors =
                (from competitor in Competitors
                 orderby competitor.Team.AveragePoints
                 select competitor).ToList();


            int halfSize = sortedCompetitors.Count() / 2;

            List<TournamentRegistration> SeededTeams = new List<TournamentRegistration>();

            for (int i = sortedCompetitors.Count() % 2 == 0 ? 0 : 1; i + halfSize < sortedCompetitors.Count(); i++)
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

        public override void SetupNextRound(List<TournamentRegistration> Competitors)
        {
            if (!IsFinals)
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
                        new Match(Competitors.Last(), (i + 2 / 2), CurrentRound);
                    }

                    //If there is no losers bracket, finals happen when 2 players remaining
                    if (!hasLosersBracket && Competitors.Count == 2)
                    {
                        IsFinals = true;
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
                    if (LosersBracket.IsFinished)
                    {
                        CreateNewMatch(Winner, LosersBracket.Winner, 1);
                        IsFinals = true;
                    }
                }
                else
                {
                    throw new Exception("I don't know how you got here. This is never meant to happen. There's some logic bug here.");
                }


            }// End of finals check

            else
            {
                IsFinished = true;
            }
        }
    }
}
