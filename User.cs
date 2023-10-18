using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Tracker
{
    internal class User
    {
        private string name = "";
        private string email = "";
        protected string id = "";

        public string Name { get => name; protected set => name = value; }
        public string Email { get => email; protected set => email = value; }
    }
}
