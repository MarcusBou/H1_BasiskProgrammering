using Microsoft.VisualBasic;
using System;

namespace Thermometer
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit, reamur;

            Console.Write("Din celsius grad: ");
            celsius = Double.Parse(Console.ReadLine());

            reamur = celsius * 0.8;
            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("Grader i Reamur: " + reamur + "\nGrader i fahrenheit: " + fahrenheit);
            Console.ReadKey();
        }
    }
}
