using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class Librarian : Person , ILibrarian
    {
        public int LibrNr { get; set; }
        public string Password { get; set; }
        public string Roll { get; set; }

    }
}
