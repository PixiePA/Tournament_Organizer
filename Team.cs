using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tournament_Tracker
{
    public class Team
    {
        private int teamID;
        private string name = "";

        public int TeamID { get => teamID; set => teamID = value; }
        [Required]
        public string Name { get => name; set => name = value; }

        [NotMapped]
        public float AveragePoints
        {
            get
            {
                List < Player > allPlayers = GetPlayers();
                int totalPoints = 0;
                foreach ( Player player in allPlayers )
                {
                    totalPoints += player.Points;
                }
                return (float)totalPoints / (float)allPlayers.Count;
            }
        }

        public void Remove()
        {
            IEnumerable<TeamRegistration> registrations =
                from registration in DatabaseManager.context.TeamRegistrations
                where registration.TeamID == TeamID
                select registration;


            foreach (var registration in registrations)
            {
                DatabaseManager.context.TeamRegistrations.Remove(registration);
            }

            DatabaseManager.context.Remove(this);

            DatabaseManager.Save();
        }

        public List<Player> GetPlayers()
        {
            List<Player> playerList = new List<Player>();
            IEnumerable<int> playerRegistations =
                from playerRegistration in DatabaseManager.context.TeamRegistrations
                where playerRegistration.TeamID == TeamID
                select playerRegistration.PlayerID;
            if (playerRegistations.Any())
            {
                try
                {
                    foreach (var playerKey in playerRegistations)
                    {
                        Player player = DatabaseManager.context.Players.Find(playerKey);

                        if (player == null) continue;

                        playerList.Add(player);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return playerList;
        }

        public void RegisterToTeam(Player player)
        {
            TeamRegistration newRegistration = new TeamRegistration();

            IEnumerable<TeamRegistration> registrations =
                from registration in DatabaseManager.context.TeamRegistrations
                where registration.TeamID == TeamID && registration.PlayerID == player.PlayerID
                select registration;

            if (registrations.Any())
            {
                throw new ArgumentException("Registration already exists");
            }
            else
            {
                newRegistration.Player = player;
                newRegistration.Team = this;
                DatabaseManager.context.TeamRegistrations.Add(newRegistration);
                DatabaseManager.Save();
            }
        }

        public void RegisterToTeam(int PlayerID)
        {
            Player playerToRegister = DatabaseManager.context.Players.Find(PlayerID);
            if (playerToRegister != null)
            {
                RegisterToTeam(playerToRegister);
            }
            else
            {
                throw new KeyNotFoundException("Player with given key does not exist");
            }
        }
    }
}
