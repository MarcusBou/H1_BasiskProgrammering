using System;
using System.Collections.Generic;
using System.Linq;

namespace Lister
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give the list some certain startup values, instead of .add method
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            List<int> listeB = new List<int>(numbers);
            int[] ReverseNumb = { 20, 18, 16, 14, 12, 10, 8, 6, 4, 2 };
            List<int> listeC = new List<int>(ReverseNumb);

            //Remove and add certain values
            listeB.Remove(6);
            listeB.Remove(12);
            listeB.Remove(15);
            listeB.Remove(18);

            listeB.Insert(2, 17);

            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine(listeB[i]);
            }
            Console.WriteLine("\n");

            //After the assignment en revserse sequence
            listeC.Insert(2, 17);
            listeC.Remove(18);
            listeC.Remove(15);
            listeC.Remove(12);
            listeC.Remove(6);
            for (int i = 0; i < listeC.Count; i++)
            {
                Console.WriteLine(listeC[i]);
            }
            Console.ReadKey();
        }
    }
}
