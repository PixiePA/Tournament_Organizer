using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    [PrimaryKey(nameof(TournamentID))]
    public class Tournament
    {
        private int tournamentID;
        private string tournamentName = "";

        public int TournamentID { get => tournamentID; set => tournamentID = value; }

        [Required]
        public string TournamentName { get => tournamentName; set => tournamentName = value; }

        [NotMapped]
        public List<TournamentRegistration> Placements
        {
            get
            {
                IEnumerable<TournamentRegistration> sortedRegistrations =
                    from registrations in AllRegistrants
                    orderby registrations.Wins
                    select registrations;
                return sortedRegistrations.ToList();
            }
        }


        public List<TournamentRegistration> AllRegistrants
        {
            get
            {
                IEnumerable<TournamentRegistration> allRegistrations =
                    from registrations in DatabaseManager.context.TournamentRegistrations
                    where registrations.TournamentID == tournamentID
                    select registrations;
                return allRegistrations.ToList();
            }
        }


        public Bracket Bracket
        {
            get
            {
                return
                    (from brackets in DatabaseManager.context.WinnersBrackets
                     where brackets.TournamentID == tournamentID
                    select brackets).First();
            }
        }


        public TournamentRegistration Winner
        {
            get
            {
                return Placements.First();
            }

        }

        public void RegisterToTournament(Team team)
        {
            TournamentRegistration newtournamentRegistration = new TournamentRegistration() { Tournament = this, Team = team};
            DatabaseManager.context.TournamentRegistrations.Add(newtournamentRegistration);
            DatabaseManager.Save();
        }

        public void AddScores()
        {
            var grpPlacements = Placements
               .GroupBy(registration => registration.Wins, registration => registration.Team, (team, teams) => new
               {
                   Team = team,

                   TeamsInRank = teams.Count(),

                   Results = teams

               });

            int teamsBeat = Placements.Count();
            int teamsLostTo = 0;

            foreach (var rank in grpPlacements)
            {
                foreach (var team in rank.Results)
                {
                    foreach (Player player in team.GetPlayers())
                    {
                        player.Points += teamsBeat;
                        player.Points -= teamsLostTo;
                        DatabaseManager.UpdateEntity(player);
                    }
                }

                teamsBeat -= rank.TeamsInRank;
                teamsLostTo += rank.TeamsInRank;
            }
        }
    }
}
