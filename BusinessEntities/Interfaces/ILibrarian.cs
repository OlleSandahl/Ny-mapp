using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Enum;

namespace BusinessEntities.Interfaces
{
    public interface ILibrarian
    {
        int LibrNr { get; set; }
        string Password { get; set; }
        string Role { get; set; }

        bool InCorrectPassword(string password); 
           
        
       
    }
}
