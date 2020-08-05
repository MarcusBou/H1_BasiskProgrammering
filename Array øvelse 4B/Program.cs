using System;
using System.Dynamic;
using System.Linq;

namespace Array_øvelse_4B
{
    class Program
    {
        static int options;
        static int[] dataStorage = new int[1000];
        static bool end = false;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Tilføj Data");
                Console.WriteLine("2. Se alt indtastede Data");
                Console.WriteLine("3. Søg efter element");
                Console.WriteLine("4. Se et resume af al Data");
                Console.WriteLine("5. Luk programmet\n");
                Console.Write("Choose a path: ");
                Int32.TryParse(Console.ReadLine(), out options);

                switch (options)
                {
                    case 1:
                        Console.Clear();
                        addData();
                        break;
                    case 2:
                        Console.Clear();
                        ShowAll();
                        break;
                    case 3:
                        Console.Clear();
                        searchData();
                        break;
                    case 4:
                        Console.Clear();
                        statisticData();
                        break;
                    case 5:
                        Console.Clear();
                        end = true;
                        break;
                    default:
                        Console.WriteLine("You picked something out of the scale");
                        break;
                }

            } while (end == false);
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
            for (int i = 0; i < dataStorage.Length; i++)
            {
                if (dataStorage[i].Equals(search))
                    Console.WriteLine(dataStorage[i]);
                        }
            Console.ReadKey();
        }

        static void statisticData()
        {
            Console.WriteLine("Statistic: \n");
            Console.WriteLine("active Cells: " + activeCells());
            Console.WriteLine("Sum of data: " + sumData());
            Console.WriteLine("Average input of data: " + gnsSum());
            Console.WriteLine("Maxed inputed data: " + dataStorage.Max());
            Console.WriteLine("Minimum inputed data: " + dataStorage.Min());
            Console.ReadKey();
        }

        static int activeCells()
        {
            int ac = 0;
            for (int i = 0; i < dataStorage.Length; i++)
            {
                if (dataStorage[i] != 0)
                {
                    ac += 1;
                }
            }
            return ac;
        }

        static float sumData()
        {
            int sum = 0;
            for (int i = 0; i < dataStorage.Length; i++)
            {
                sum += dataStorage[i];
            }
            return sum;
        }

        static float gnsSum()
        {
            return sumData() / 2;
        }
    }
}
