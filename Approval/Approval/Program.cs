using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval
{
    class Program : Manager
    {
        public static void Main(string[] args)
        {
            theMain();

            Console.ReadLine();

        }

        //method to main menu
        protected static void theMain()
        {
            int inputPrice;

            //Calling Property, make objects
            Manager theManager = new Manager();
            Director theDirector = new Director();
            Vice_President theVP = new Vice_President();
            
            //name
            Console.Write("Nama Manager : ");
            theManager.Name = Console.ReadLine();
            Console.Write("Nama Director : ");
            theDirector.Name = Console.ReadLine();
            Console.Write("Nama Vice President : ");
            theVP.Name = Console.ReadLine();

            Console.Clear();

            //input harga
            Console.Write("Masukkan harga beli = Rp. ");
            inputPrice = Convert.ToInt32(Console.ReadLine());

            theManager.HargaBeli = inputPrice;
            theDirector.HargaBeli = inputPrice;
            theVP.HargaBeli = inputPrice;

            Console.Write("Masukkan harga Vice President = Rp. ");
            theVP.hargaVP = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan harga Director = Rp. ");
            theDirector.hargaDirector = Convert.ToInt32(Console.ReadLine());

            theManager.hargaManager = theDirector.hargaDirector;

            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");

            //CONDITION
            if(inputPrice > theVP.hargaVP && inputPrice > theDirector.hargaDirector)
            {
                theManager.ManagerApp();
                theVP.VPApp();
                theDirector.DirectorApp();
            }
            else if (inputPrice > theVP.hargaVP)
            {
                theManager.ManagerNotApp();
                theDirector.DirectorNotApp();
                theVP.VPApp();
            }
            else if (inputPrice >= theDirector.hargaDirector)
            {
                theManager.ManagerNotApp();
                theDirector.DirectorApp();
                theVP.VPNotApp();
            }
            else
            {
                theManager.ManagerApp();
            }

            Console.ReadLine();

            toMainMenu();
        }

        //Method back to main menu
        private static void toMainMenu()
        {
            char repeat;

            Console.Write("Back to main menu? [Y]/[T] : ");
            string back = Convert.ToString(Console.ReadLine());

            if (back == "Y" || back == "y")
            {
                Console.Clear();
                theMain();
            }
            else if (back == "T" || back == "t")
            {
                Console.Clear();
                Console.WriteLine("Session ends");
            }
            else
            {
                Console.WriteLine("Input Anda tidak sesuai");
                Console.WriteLine("Input [Y] untuk mengulangi, [T] untuk mengakhiri");

                repeat = Convert.ToChar(Console.ReadLine());

                if (repeat == 'Y' || repeat == 'y')
                {
                    Console.Clear();
                }
                else {
                }
            }
        }
    }
}
