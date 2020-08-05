using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static int[] winningNum = new int[7];
        static int[] playerNum = new int[7];
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < winningNum.Length; i++)
            {
                winningNum[i] = rnd.Next(1, 21);
            }

            Console.WriteLine("Velkommen til lotto");
            Console.Write("Skriv dine ønskede 7 cifre mellem 1 og 20(med et mellem rum imellem): ");
            string stringWrited = Console.ReadLine();

            string[] Translation = stringWrited.Split(" ");
            for (int i = 0; i < Translation.Length; i++)
            {
                Int32.TryParse(Translation[i], out playerNum[i]);
            }
            Console.Clear();
            Console.WriteLine("The winning number is!!!");
            Console.WriteLine("[{0}]", string.Join(", ", winningNum));
            Console.WriteLine("\nYou have these numbers!!!");
            Console.WriteLine("[{0}]", string.Join(", ", playerNum));
            switch (customWin())
            {
                case 1:
                    Console.WriteLine(customWin() + " Match, try again ");
                    break;
                case 2:
                    Console.WriteLine(customWin() + " Matches, try again ");
                    break;
                case 3:
                    Console.WriteLine(customWin() + " Matches, You win 100$");
                    break;
                case 4:
                    Console.WriteLine(customWin() + " Matches, You win 1000$");
                    break;
                case 5:
                    Console.WriteLine(customWin() + " Matches, You win 10000$");
                    break;
                case 6:
                    Console.WriteLine(customWin() + " Matches, You win 50000$");
                    break;
                case 7:
                    Console.WriteLine(customWin() + " Matches, You win 100000$");
                    break;
                default:
                    Console.WriteLine("No Match try again");
                    break;
            }
        }

        static int customWin()
        {
            int Corrects = 0;
            for (int i = 0; i < winningNum.Length; i++)
            {
                if (playerNum.Contains(winningNum[i]))
                {
                    Corrects += 1;
                }
            }
            return Corrects;
        }
    }
}
