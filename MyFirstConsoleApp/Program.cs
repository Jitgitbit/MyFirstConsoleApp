using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.WriteLine("Hello, " + name);


            Console.WriteLine("C# is cool!");

            Console.WriteLine("And what do you want?");
            string want = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.Clear();


            Console.WriteLine("Then you should go for " +want);


            Console.ReadKey();
        }
    }
}
