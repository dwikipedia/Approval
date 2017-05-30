using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval
{
    class Vice_President : Manager
    {
        public void VPApp()
        {
            Console.WriteLine("3. Vice President {0} Approve dengan harga beli lebih dari {1}, yaitu {2:N}", Name, hargaVP, HargaBeli);
        }

        public void VPNotApp()
        {
            Console.WriteLine("3. Vice President {0} Not Approve harga {1:N} ", Name, HargaBeli);
        }
    }
}
