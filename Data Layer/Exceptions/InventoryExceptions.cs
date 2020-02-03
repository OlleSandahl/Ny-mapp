using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Exceptions
{
    public class InventoryExceptions: Exception
    {
        public InventoryExceptions()
            : base()
        {
        }

        public InventoryExceptions(string message)
            : base()
        {
        }

        public InventoryExceptions(string message, Exception inner)
            : base(message, inner)
        {
        }



    }
}
