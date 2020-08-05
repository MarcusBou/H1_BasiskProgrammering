using System;
using System.Diagnostics.CodeAnalysis;

namespace Array_øvelse_4
{
    class Program
    {
        static int[,] grade = new int[10, 2];
        static double sum;

        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.Write("skriv karaktere for din første elev gruppe, en karakter af gangen: ");
                Int32.TryParse(Console.ReadLine(), out grade[i, 0]);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("skriv karaktere for din Anden elev gruppe, en karakter af gangen: ");
                Int32.TryParse(Console.ReadLine(), out grade[i, 1]);
            }
            Console.WriteLine("Gennem snittet for Første elev gruppe er: " + gnsFørsteKlasse());
            Console.WriteLine("Gennem snittet for Anden elev gruppe er: " + gnsAndenKlasse());
        }

        static double gnsFørsteKlasse()
        {
            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += grade[i, 0];
            }
            return sum / 10;
        }

        static double gnsAndenKlasse()
        {
            sum = 0;
            for (int j = 0; j < 10; j++)
            {
                sum += grade[j, 1];
            }
            return sum / 10;
        }
    }
}
