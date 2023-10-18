using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class Player : User
    {
        private int wins = 0;
        private Rank rank = Rank.None;

        public string PlayerID { get => id; set => id = value; }
        public int Wins { get => wins; set => wins = value; }
        public Rank Rank { get => rank; set => rank = value; }

        public Player(string name, int wins, Rank rank, string email)
        {
            this.Name = name;
            this.wins = wins;
            this.rank = rank;
            this.Email = email;
        }
    }
}
