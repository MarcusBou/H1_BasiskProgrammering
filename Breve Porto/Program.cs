using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Breve_Porto
{
    class Program
    {
        static Double[] weightPossible = { 50, 100, 250, 500, 1000, 2000 };
        static Double[] weightPricing = { 10, 20, 40, 60, 60, 60 };
        static Double[] OutlandweightPricing = { 30, 30, 60, 60, 90, 90 };
        static string dest;
        static double thick, length, width, weight;
        static void Main(string[] args)
        {
            Console.Write("Wished for destination: ");
            dest = Console.ReadLine();
            Console.Write("length of letter:");
            length = Double.Parse(Console.ReadLine());
            Console.Write("Width of letter:");
            width = Double.Parse(Console.ReadLine());
            Console.Write("thickness of letter:");
            thick = Double.Parse(Console.ReadLine());
            Console.Write("Weight of letter in gram: ");
            weight = Double.Parse(Console.ReadLine());

            sizeCheck();
        }

        static void sizeCheck()
        {
            dest.ToLower();
            if (length >= 16  && width >= 9 && length <= 60 && weight <= 2000)
            {
                Console.WriteLine("Godkendt");
                if (dest == "danmark")
                {
                    for (int i = 0; i < weightPossible.Length; i++)
                    {

                        if (weight <= weightPossible[0])
                        {
                            Console.WriteLine("Price to send letter: " + weightPricing[i]);
                            break;
                        }
                        else if (weight >= weightPossible[i] && weight <= weightPossible[i + 1])
                        {
                            Console.WriteLine("Price to send letter: " + weightPricing[i + 1]);
                            break;
                        }
                    }
                }
                else if (dest != "danmark")
                {
                    for (int i = 0; i < weightPossible.Length; i++)
                    {

                        if (weight <= weightPossible[0])
                        {
                            Console.WriteLine("Price to send letter: " + OutlandweightPricing[i]);
                            break;
                        }
                        else if (weight >= weightPossible[i] && weight <= weightPossible[i + 1])
                        {
                            Console.WriteLine("Price to send letter: " + OutlandweightPricing[i + 1]);
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ikke Godkendt brev størrelse");
            }
        }
    }
}
