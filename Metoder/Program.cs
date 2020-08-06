using System;
using System.Security.Cryptography.X509Certificates;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv dit første tal: ");
            Int32.TryParse(Console.ReadLine(), out int tal1);
            Console.Write("Skriv dit Andet Tal tal: ");
            Int32.TryParse(Console.ReadLine(), out int tal2);
            Console.WriteLine("\n" + add(tal1, tal2));
            Console.WriteLine(dividing(tal1, tal2));
            Console.WriteLine(potens(tal1, tal2));
        }

        static double add(int t1, int t2)
        {
            return t1 + t2;
        }

        static double dividing(int t1, int t2)
        {
            return t1 / t2;
        }

        static double potens(int t1, int t2)
        {
            return Math.Pow(t2, t1);
        }
    }
}
