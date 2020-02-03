using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    interface ILibrarian
    {
        int LibrNr { get; set; }
        string Password { get; set; }
        string Roll { get; set; }
    }
}