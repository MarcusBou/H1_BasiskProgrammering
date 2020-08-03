using System;

namespace Terningekastet
{
    class Program
    {
        static void Main(string[] args)
        {
            //en do while
            do
            {
                //en random som skal simulere en terningekast
                Random rnd = new Random();

                int terning = rnd.Next(1, 7);
                
                //for at se hvilket tal på terninge bruger jeg et switchcase statement
                //jeg bruger consolecolor til at give de forskellige tal, deres egen farve.
                switch (terning)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("du slog en 1");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("du slog en 2");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("du slog en 3");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("du slog en 4");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("du slog en 5");
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("du slog en 6");
                        break;
                }

                Console.ReadKey();
            } while (true);
        }
    }
}
