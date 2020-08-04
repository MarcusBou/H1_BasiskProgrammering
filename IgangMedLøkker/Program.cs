using System;

namespace IgangMedLøkker
{
    class Program
    {
        static void Main(string[] args)
        {
            //A: for loop runs up to a hundred
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            //B: for Loop runs to hundred but only print to fifty
            for (int j = 0; j < 100; j++)
            {
                if (j <= 50)
                {
                    Console.WriteLine(j);
                }
            }

            //C: While loop runs to hundred
            int k = 0;
            while (k <= 100)
            {
                Console.WriteLine(k);
                k++;
            }

            //for loop runs to zero from hundred
            for (int l = 100; l > 0; l--)
            {
                Console.WriteLine(l);
            }
        }
    }
}
