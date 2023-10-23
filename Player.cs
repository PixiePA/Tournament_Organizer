using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tournament_Tracker
{
    internal class Player : User
    {
        private int wins = 0;
        private int losses = 0;
        

        public int PlayerID { get => id; set => id = value; }
        public int Wins { get => wins; set => wins = value; }
        public int Losses { get => losses; set => losses = value; }




        public Player() { }

        public Player(string name, int wins, int losses, string email)
        {
            this.Name = name;
            this.wins = wins;
            this.losses = losses;
            this.Email = email;
        }
    }
}
