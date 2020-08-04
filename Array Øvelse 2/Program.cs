using Microsoft.VisualBasic.FileIO;
using System;
using System.Linq;

namespace Array_Øvelse_2
{
    class Program
    {
        static string[] boyName = { "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias",
                                    "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias" };
        static string searchWord;
        static void Main(string[] args)
        {
            Array.Sort(boyName);
            for (int i = 0; i < boyName.Length; i++)
            {
                Console.WriteLine(boyName[i]);
            }
            Console.Write("search: ");
            searchWord = Console.ReadLine();
            Console.WriteLine(boyName.Contains(searchWord));
            Console.ReadKey();
        }
    }
}
