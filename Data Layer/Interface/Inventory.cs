using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Interfaces;


namespace Data_Layer.Interface
{
    public interface Inventory
    {
        IList<ILibrarian> GetLibrarians();
        IList<Ibook> GetIbooks();
    }
}
