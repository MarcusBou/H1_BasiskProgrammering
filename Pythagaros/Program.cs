using System;

namespace Pythagaros
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("din A værdi: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("din B værdi: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("din C værdig er: " + pythagaros(Math.Pow(a, 2), Math.Pow(b, 2)));
            
            //if statement så man kan se hvad er størst
            if (Math.Pow(a, 2) > Math.Pow(b, 2))
            {
                Console.WriteLine("A er størst med værdien: " + Math.Pow(a, 2));
            }
            else if (Math.Pow(a, 2) > Math.Pow(b, 2))
            {
                Console.WriteLine("B er størst med værdien: " + Math.Pow(b, 2));
            }
        }

        static double pythagaros(double A, double B)
        {
            return A + B;
        }
    }
}
