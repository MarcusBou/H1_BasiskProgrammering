
using System;

namespace ValutaOmregneren
{
    class Program
    {
        static double dkk, usd, pund, euro, sek;

        static void Main(string[] args)
        {
                Console.Write("Værdien du vil have omregnet i DKK: ");
                dkk = double.Parse(Console.ReadLine());

                convert(dkk);

                Console.Clear();

                Console.WriteLine(dkk + "kr. i de forskellige valutaer\n\n" +
                    "US dollar: " + usd + "\n" +
                    "Britiske Pund: " + pund + "\n" +
                    "Euro: " + euro + "\n" +
                    "Svensk Krone: " + sek);

            Console.ReadKey();
        }

        static void convert(double Dkk) 
        {
            usd = Dkk * 6.32;
            pund = Dkk * 8.28;
            euro = Dkk * 7.44;
            sek = Dkk * 0.72;
        }
    }
}
