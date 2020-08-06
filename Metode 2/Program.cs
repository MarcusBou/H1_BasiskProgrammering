using System;
using System.Runtime.InteropServices;

namespace Metode_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            Count();
            Console.WriteLine("Main");
            Console.ReadKey();
        }

        public static void Count(int a)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
