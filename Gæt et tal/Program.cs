using System;
using System.Timers;

namespace Gæt_et_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int GNum, timesGuessed;

            int LuckyNumber = rnd.Next(0, 100);
            timesGuessed = 0;
            do
            {
                Console.WriteLine("Times Tried: " + timesGuessed);
                Console.Write("Guess a number: ");
                GNum = Int32.Parse(Console.ReadLine());

                timesGuessed++;

                if (GNum == LuckyNumber)
                {
                    Console.WriteLine("Tillykke Du Vandt");
                    Console.WriteLine(RewardingWords(timesGuessed));
                }

                else if (GNum > LuckyNumber)
                {
                    Console.WriteLine("Too high");
                }

                else if (GNum < LuckyNumber)
                {
                    Console.WriteLine("Too Low");
                }
            } while (true);
        }

        private static string RewardingWords(int TNum) {
            if (TNum == 1)
            {
                return "Skide godt første forsøg";
            }
            else if (TNum > 1 && TNum <= 5)
            {
                return "Super tæt på";
            }
            else if (TNum > 5 && TNum <= 10)
            {
                return "Det kunne du klare bedre prøv igen";
            }
            else if (TNum > 10 && TNum <= 20)
            {
                return "Det sku lidt sløset";
            }
            else if (TNum > 20)
            {
                return "Nu må du godt tage dig sammen";
            }

            return "nej";
        }
    }
}
