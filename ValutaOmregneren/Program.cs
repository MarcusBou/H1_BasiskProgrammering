
using System;

namespace ValutaOmregneren
{
    class Program
    {
        static double dkk, usd, pund, euro, sek;

        static void Main(string[] args)
        {
            //Modtager dataen omkring værdien der skal udregnes
                Console.Write("Værdien du vil have omregnet i DKK: ");
                dkk = double.Parse(Console.ReadLine());

            //sender til udregningen
                convert(dkk);

                Console.Clear();

            //udprinter udregningerne
                Console.WriteLine(dkk + "kr. i de forskellige valutaer\n\n" +
                    "US dollar: " + usd + "\n" +
                    "Britiske Pund: " + pund + "\n" +
                    "Euro: " + euro + "\n" +
                    "Svensk Krone: " + sek);

            Console.ReadKey();
        }

        static void convert(double Dkk) 
        {
            //udregning For de forskellige valutaer
            usd = Dkk * 0.15;
            pund = Dkk * 0.12;
            euro = Dkk * 0.13;
            sek = Dkk * 1.38;
        }
    }
}
