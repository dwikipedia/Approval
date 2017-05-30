using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval
{
    internal class Manager
    {
        //property
        public string Name { get; set; }
        protected int hargaBeli { get; set; }
        public int hargaVP { get; set; }
        public int hargaDirector { get; set; }
        public int hargaManager { get; set; }

        public int HargaBeli
        {
            get { return hargaBeli; }
            set { hargaBeli = value; }
        }
        public void ManagerApp()
        {
            Console.WriteLine("\n1. Manager {0} Approve dengan harga beli kurang dari {1}, yaitu {2:N}", Name, hargaManager, hargaBeli);
        }

        public void ManagerNotApp()
        {
            Console.WriteLine("1. Manager {0} Not Approve harga {1:N}", Name, hargaBeli);
        }

    }
}
