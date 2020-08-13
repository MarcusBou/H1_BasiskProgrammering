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
            Console.Write("\nSearch: ");
            searchWord = Console.ReadLine();
            for (int i = 0; i < boyName.Length - 1; i++)
            {
                if (boyName[i].Contains(searchWord))
                    {
                
                        Console.WriteLine(boyName[i].ToString());
                    }
            }
            Console.ReadKey();
        }
    }
}
