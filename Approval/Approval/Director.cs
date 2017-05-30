using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval
{
    class Director : Manager
    {
        public void DirectorApp()
        {
            Console.WriteLine("2. Director {0} Approve dengan harga beli sama dengan {1}, yaitu {2:N}", Name, hargaDirector, HargaBeli);
        }

        public void DirectorNotApp()
        {
            Console.WriteLine("2. Director {0} Not Approve harga {1:N} ", Name, HargaBeli);
        }

    }
}
