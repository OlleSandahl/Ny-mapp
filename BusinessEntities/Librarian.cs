using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Enum;
using BusinessEntities.Interfaces;


namespace BusinessEntities
{
    class Librarian : Person, ILibrarian
    {
        public int LibrNr { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Librarian(int librNr, string password, string role)
        {
            LibrNr = librNr;
            Password = password;
            Role = role;
        }

        public bool InCorrectPassword(string password)
        {
            return String.Equals(Password, password);
        }
     }
}
