using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Enum;

namespace BusinessEntities.Interfaces
{
    public interface Ibook
    {
        string Title { get; set; }
        int ISBN { get; set; }
        bool Availability { get; set; }
        bool Choose { get; set; }
        State state { get; set; }

        void Loan();
        void Return();
    }
}
