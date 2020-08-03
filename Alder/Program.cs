using System;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age;
            string name;

            Console.Write("Skriv dit navn: ");
            name = Console.ReadLine();

            Console.Write("Skriv din alder: ");
            age = Byte.Parse(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine(name +", du må gå med ble");
            }
            else if(age > 3 && age <= 15)
            {
                Console.WriteLine(name +", du må ingenting");
            }
            else if (age > 15 && age < 18)
            {
                Console.WriteLine(name + ", du må drikke");
            }
            else if(age >= 18)
            {
                Console.WriteLine(name + ", du må stemme og køre bil");
            }

            Console.ReadKey();
        }
    }
}
