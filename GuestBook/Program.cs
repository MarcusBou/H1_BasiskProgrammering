using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace GuestBook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shutdown = false;
            do
            {
                GUI();
            } while (shutdown == false);
        }

        public static void GUI()
        {
            Console.WriteLine("Velkommen til Gæstebogen: \n");
            Console.WriteLine("1. Se Gærste Bogen");
            Console.WriteLine("2. Tilføj Gæst");
            Console.WriteLine("3. Søg efter Email/Slet og opdatere kommentar");

            Console.Write("Vælg en vej: ");
            Int32.TryParse(Console.ReadLine(), out int options) ;

            switch (options)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("You wrote something outta range");
                    break;
            }


        }
    }
}
