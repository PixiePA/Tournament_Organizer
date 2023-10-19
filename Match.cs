using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Tournament_Tracker
{
    internal class Match
    {
        private int matchID;
        private int registrationID_A;
        private int registrationID_B;
        private int bracketID;
        private int[] score = new int[2];
        private int maxRounds;
        private bool playAll = false;

        public int MatchID { get => matchID; set => matchID = value; }
        public int RegistrationID_A { get => registrationID_A; set => registrationID_A = value; }
        public int RegistrationID_B { get => registrationID_B; set => registrationID_B = value; }
        public int BracketID { get => bracketID; set => bracketID = value; }
        public int[] Score { get => score; set => score = value; }
        public int MaxRounds { get => maxRounds; set => maxRounds = value; }
        public bool PlayAll { get => playAll; set => playAll = value; }

        public void ReportAWin()
        {
            score[0]++;
        }

        public void ReportBWin()
        {
            score[1]++;
        }

        public void ReportAScore(int score)
        {
            this.score[0] = score;
        }

        public void ReportBScore(int score)
        {
            this.score[1] = score;
        }

        public void ReportScore(int scoreA, int scoreB)
        {
            score[0] = scoreA;
            score[1] = scoreB;
        }

        public bool IsMatchOver()
        {
            int roundsPlayed = score[0] + score[1];
            int scoreToWin = (maxRounds - 1) / 2;
            if ((score[0] >= scoreToWin || score[1] >= scoreToWin) && playAll == false)
            {
                return true;
            }
            else if (roundsPlayed >= maxRounds)
            {
                return true;
            }

            return false;
        }

        public int GetWinnerRegistrationID()
        {
            if (IsMatchOver())
            {
                return score[0] > score[1] ? score[0] : score[1];
            }
            else throw new InvalidOperationException("Match is still ongoing");
        }

        public void AutoPlayMatch()
        {
            Random rnd = new Random();
            while (!IsMatchOver())
            {
                if (rnd.NextInt64(0,10) < 5)
                {
                    ReportAWin();
                }
                else
                {
                    ReportBWin();
                }
            }
        }
    }
}
