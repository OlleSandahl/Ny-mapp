using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Interfaces;

namespace BusinessEntities
{
    class Book : Ibook
    {
        public string Title { get; set; }
        public int ISBN { get; set; }
        public bool Availability { get; set; }
        public bool Choose { get; set; }
        public State state { get; set; }

        public Book(string title, int isbn)
        {
            Title = title;
            ISBN = isbn;
            state = State.Available;
            Availability = true;
        }

        public void Loan()
        {
            state = State.Reserved;
            Availability = false;
        }
        public void Return()
        {
            state = State.Returned;
            Availability = true;
        }
    }
}
