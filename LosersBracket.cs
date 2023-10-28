using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    public class LosersBracket : Bracket
    {
        private int winnersBracketID;

        [ForeignKey(nameof(WinnersBracket))]
        public int WinnersBracketID { get => winnersBracketID; set => winnersBracketID = value; }

        public Bracket WinnersBracket { get; set; }

        public override bool BeginNextRound()
        {
            if (!IsFinished)
            {

                List<TournamentRegistration> Winners = AllWinnersInRound(CurrentRound);
                foreach (TournamentRegistration winner in Winners)
                {
                    winner.Wins++;
                    DatabaseManager.UpdateEntity(winner);
                }

                List<TournamentRegistration> WinnersBracketLosers = DatabaseManager.context.Brackets.Find(winnersBracketID).AllWinnersInRound(CurrentRound);

                List<TournamentRegistration> NextRoundCompetitors = new List<TournamentRegistration>();

                for (int i = 0; i < (Winners.Count > WinnersBracketLosers.Count ? Winners.Count : WinnersBracketLosers.Count); i++)
                {
                    if (i < Winners.Count)
                    {
                        NextRoundCompetitors.Add(Winners[i]);
                    }

                    if (i < WinnersBracketLosers.Count)
                    {
                        NextRoundCompetitors.Add(WinnersBracketLosers[i]);
                    }
                }

                SetupNextRound(NextRoundCompetitors);


            }// End of finished check

            DatabaseManager.UpdateEntity(this);

            return IsFinished;
        }



    }
}
