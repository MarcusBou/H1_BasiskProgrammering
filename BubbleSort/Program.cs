using System;

namespace BubbleSort
{
    class Program
    {
        static int[] rndArr = new int[100];
        static Random rnd = new Random();
        static bool swap = false;

        static void Main(string[] args)
        {
            for (int i = 0; i < rndArr.Length; i++)
            {
                rndArr[i] = rnd.Next(0, 100);
            }

            for (int i = 0; i < rndArr.Length - 1; i++)
            {
                for (int j = 0; j < rndArr.Length - 1; j++)
                {
                    if (rndArr[j] > rndArr[j + 1])
                    {
                        int temp = rndArr[j];
                        rndArr[j] = rndArr[j + 1];
                        rndArr[j + 1] = temp;
                        swap = true;
                    }
                }
                if (swap == false)
                {
                    i = 100;
                }
            }

            for (int i = 0; i < rndArr.Length; i++)
            {
                Console.WriteLine(rndArr[i]);
            }
            Array.Reverse(rndArr);
            Console.WriteLine("\n");
            for (int i = 0; i < rndArr.Length; i++)
            {
                Console.WriteLine(rndArr[i]);
            }
        }
    }
}
