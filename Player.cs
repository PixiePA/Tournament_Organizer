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
        private int points = 0;
        

        public int PlayerID { get => id; set => id = value; }
        public int Points { get => points; set => points = value; }

        public Player() { }

        public Player(string name, int points, string email)
        {
            this.Name = name;
            this.points = points;
            this.Email = email;
        }
    }
}
