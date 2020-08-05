using System;
using System.Dynamic;

namespace Array_øvelse_4B
{
    class Program
    {
        static int options;
        static int[] dataStorage = new int[1000];
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("1. Tilføj Data");
                Console.WriteLine("2. Se alt indtastede Data");
                Console.WriteLine("3. Søg efter element");
                Console.WriteLine("4. Se et resume af al Data");
                Console.WriteLine("5. Luk programmet\n");
                Console.Write("Choose a path: ");
                Int32.TryParse(Console.ReadLine(), out options) ;

                switch (options)
                { 
                    case 1:
                        addData();
                        break;
                    case 2:
                        ShowAll();
                        break;
                    case 3:
                        searchData();
                        break;
                    case 4:
                        statisticData();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("You picked something out of the scale");
                        break;
                }

                static void addData()
                {
                    int newData;
                    Console.Write("What you want to add too the data Sheeta: ");
                    Int32.TryParse(Console.ReadLine(), out newData);

                    for (int i = 0; i < dataStorage.Length; i++)
                    {
                        if (dataStorage[i] == 0)
                        {
                            dataStorage[i] = newData;
                            i = 10000;
                        }
                    }
                }

                static void ShowAll()
                {
                    for (int i = 0; i < dataStorage.Length; i++)
                    {
                        if (dataStorage[i] != 0)
                        {
                            Console.WriteLine(dataStorage[i]);
                        }
                    }
                }

                static void searchData()
                {
                    int search;
                    Console.Write("Seach after digital number: ");
                    Int32.TryParse(Console.ReadLine(), out search);
                }

                static void statisticData()
                {
                    Console.WriteLine("statistik");
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}
