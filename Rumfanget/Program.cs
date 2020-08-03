using System;

namespace Rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, b, l;

            Console.WriteLine("input kassens højde længde og bredde, nedenunder.");
            Console.Write("Højde: ");
            h = Double.Parse(Console.ReadLine());
            Console.Write("Bredde: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("længde: ");
            l = Double.Parse(Console.ReadLine());

            Console.WriteLine("Volumen på kassen med målene " + h +" i højde " + b + " i bredde" + l + " i længde" +
                "\nHar Volumen/rumfanget: " + Volume(h,b,l));

            Console.ReadKey();
        }

        static double Volume(double H, Double B, Double L) {
            double output = H * B * L;
            return output;
        }
    }
}
