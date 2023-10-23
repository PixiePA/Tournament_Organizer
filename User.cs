using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class User
    {
        private string name = "";
        private string email = "";
        private string password = "";
        protected int id;

        [Required]
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public string Password { get => password; set => password = value; }
    }
}
