using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Manga_Management
{
    internal class Encap
    {
        private string usern;
        private string password;
        private string name;
        public string Username { set { usern = value; } get { return usern; }  }
        public string Password { set { password = value; } get { return password; } }

        public string Name { set { name = value; } get { return name; } }

        public Encap(string UserName, string Password, string Named) { this.usern = UserName; this.password = Password; this.name = Named; }
    }
}
