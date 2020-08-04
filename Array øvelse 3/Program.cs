using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_øvelse_3
{
    class Program
    {
        static List<string> boyName = new List<string>{ "William", "Oliver", "Noah", "Emil", "Victor", "Magnus", "Frederik", "Mikkel", "Lucas", "Alexander", "Oscar", "Mathias", "Sebastian", "Malthe", "Elias", "Christian", "Mads", "Gustav", "Villads", "Tobias" };
        static List<string> girlName = new List<string> { "Hanne"};
        static string searchWord, BorG, newName, deletedName;
        static int option;
        static bool end = false;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. View all names");
                Console.WriteLine("2. Add Name");
                Console.WriteLine("3. Delete Name");
                Console.WriteLine("4. End program \n");
                Console.Write("Choose and option: ");
                Int32.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        showNames();
                        break;
                    case 2:
                        addName();
                        break;
                    case 3:
                        delName();
                        break;
                    case 4:
                        end = true;
                        break;
                    default:
                        Console.WriteLine("You picked something out of the scale");
                        break;
                }
            } while (end == false);
        } 

        static void showNames()
        {
            Console.Clear();
            boyName.Sort();
            girlName.Sort();
            Console.WriteLine("Boys:");
            for (int i = 0; i < boyName.Count; i++)
            {
            Console.WriteLine(boyName[i]);
            }
            Console.WriteLine("\nGirls:");
            for (int i = 0; i < girlName.Count; i++)
            {
                Console.WriteLine(girlName[i]);
            }
            Console.Write("\nSearch: ");
            searchWord = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < boyName.Count; i++)
            {
               if (boyName[i].Contains(searchWord))
               Console.WriteLine(boyName[i].ToString());
            }

            for (int i = 0; i < girlName.Count; i++)
            {
                if (girlName[i].Contains(searchWord))
                Console.WriteLine(girlName[i].ToString());
            }
            Console.ReadKey();
        }

        static void addName()
        {
            Console.Clear();
            Console.Write("is it a Boy or Girl (write B or G)");
            BorG = Console.ReadLine();
            Console.Write("the Name:");
            newName = Console.ReadLine();

            if (BorG == "B")
            {
                boyName.Add(newName);
            }
            else if (BorG == "G")
            {
                girlName.Add(newName);
            }
            Console.WriteLine(newName + " Has been added");
        }

        static void delName()
        {
            Console.Clear();
            Console.Write("Name you want Deleted: ");
            deletedName = Console.ReadLine();

            if (boyName.Contains(deletedName))
            {
                boyName.Remove(deletedName);
            }
            else if (girlName.Contains(deletedName))
            {
                girlName.Remove(deletedName);
            }
            else
            {
                Console.WriteLine("name wasnt found");
            }
            Console.WriteLine(deletedName + " Has been removed");
            Console.ReadKey();
        }
    }
}
