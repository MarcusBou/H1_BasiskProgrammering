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

            Console.WriteLine("din C værdig er: " +  pythagaros(a, b));
            
            //if statement så man kan se hvad er størst
            if (AiA(a) > BiA(b))
            {
                Console.WriteLine("A er størst med værdien: " + AiA(a));
            }
            else if (AiA(a) > BiA(b))
            {
                Console.WriteLine("B er størst med værdien: " + BiA(b));
            }
        }
        //pythagaros udregningen
        static double pythagaros(double A, double B)
        {
            return AiA(A) + BiA(B);
        }

        //udregning af i anden
        static double AiA(double A)
        {
            return A * A;
        }

        static double BiA(double B)
        {
            return B * B;
        }
    }
}
