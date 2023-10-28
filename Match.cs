using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    public class Match
    {
        private int matchID;
        private int scoreA;
        private int scoreB;
        private int maxRounds;
        private bool playAll = false;
        private int bracketID;
        private int roundPosition;
        private int roundNumber;

        //ID Primary key
        public int MatchID { get => matchID; set => matchID = value; }

        //Parameters for keeping track of rounds to play and score
        public int ScoreA { get => scoreA; set => scoreA = value; }

        public int ScoreB { get => scoreB; set => scoreB = value; }

        public int MaxRounds { get => maxRounds; set => maxRounds = value; }
        public bool PlayAll { get => playAll; set => playAll = value; }

        //Foreign key of bracket match is held in
        [ForeignKey(nameof(Bracket))]
        public int BracketID { get => bracketID; set => bracketID = value; }

        public Bracket Bracket { get; set; }

        //Where and when the match is run in the bracket
        public int RoundPosition { get => roundPosition; set => roundPosition = value; }
        public int RoundNumber { get => roundNumber; set => roundNumber = value; }

        [NotMapped]
        public Team TeamA
        {
            get
            {
                return DatabaseManager.context.MatchRegistrations.Find(matchID, true).Team;
            }
        }

        [NotMapped]
        public Team TeamB
        {
            get
            {
                return DatabaseManager.context.MatchRegistrations.Find(matchID, false).Team;
            }
        }

        //Functions for reporting a win
        public void ReportAWin()
        {
            scoreA++;
            DatabaseManager.UpdateEntity(this);
        }

        public void ReportBWin()
        {
            scoreB++;
            DatabaseManager.UpdateEntity(this);
        }

        public void ReportAScore(int score)
        {
            this.scoreA = score;
            DatabaseManager.UpdateEntity(this);
        }

        public void ReportBScore(int score)
        {
            this.scoreB = score;
            DatabaseManager.UpdateEntity(this);
        }

        public void ReportScore(int scoreA, int scoreB)
        {
            this.scoreA = scoreA;
            this.scoreB = scoreB;
            DatabaseManager.UpdateEntity(this);
        }

        //Check if match is concluded
        public bool IsMatchOver()
        {
            int gamesPlayed = scoreA + scoreB;

            //Assuming maxRounds is odd (which it should be) calculated the amount of games needed to win majority
            int scoreToWin = (maxRounds + 1) / 2;

            //If it is not required to play every game, see if either player has won a majority of games
            if ((scoreA >= scoreToWin || scoreB >= scoreToWin) && playAll == false)
            {
                return true;
            }
            //Otherwise match is over if the number of games played equal or greater than max rounds
            else if (gamesPlayed >= maxRounds)
            {
                return true;
            }

            return false;
        }

        //If match is over, return player with higher score
        public int GetWinnerRegistrationID()
        {
            if (IsMatchOver())
            {
                return scoreA > scoreB ? TeamA.TeamID : TeamB.TeamID;
            }
            else throw new InvalidOperationException("Match is still ongoing");
        }

        //Randomly decide winner of each game
        public void AutoPlayMatch()
        {
            Random rnd = new Random();
            while (!IsMatchOver())
            {
                if (rnd.NextInt64(0, 10) < 5)
                {
                    ReportAWin();
                }
                else
                {
                    ReportBWin();
                }
            }
        }

        private void SetupMatch(Team teamA, Team teamB, int roundPosition, int roundNumber, int maxRounds = 3, bool playAllRounds = false)
        {
            MatchRegistration registrationA = new MatchRegistration() { Team = teamA, IsAlpha = true, Match = this };
            MatchRegistration registrationB = new MatchRegistration() { Team = teamB, IsAlpha = false, Match = this };
            this.maxRounds = maxRounds;
            this.playAll = playAllRounds;
            this.roundNumber = roundNumber;
            this.roundPosition = roundPosition;
            DatabaseManager.context.Matches.Add(this);
            DatabaseManager.Save();
        }

        public Match()
        {

        }

        public Match(Team teamA, Team teamB, int roundPosition, int roundNumber, int maxRounds = 3, bool playAllRounds = false)
        {
            SetupMatch(teamA, teamB, roundPosition, roundNumber, maxRounds, playAllRounds);
        }

        public Match(TournamentRegistration RegistrationA, TournamentRegistration RegistrationB, int roundPosition, int roundNumber, int maxRounds = 3, bool playAllRounds = false)
        {
            SetupMatch(RegistrationA.Team, RegistrationB.Team, roundPosition, roundNumber, maxRounds, playAllRounds);
        }

        public Match(TournamentRegistration RegistrationA, int roundPosition, int roundNumber, int maxRounds = 3, bool playAllRounds = false)
        {
            MatchRegistration registrationA = new MatchRegistration() { Team = RegistrationA.Team, IsAlpha = true, Match = this };
            this.maxRounds = maxRounds;
            this.playAll = playAllRounds;
            this.roundNumber = roundNumber;
            this.roundPosition = roundPosition;

            if (playAllRounds)
            {
                ReportAScore(maxRounds);
            }
            else
            {
                ReportAScore((maxRounds+1)/2);
            }
            DatabaseManager.UpdateEntity(this);
        }

    }
}
