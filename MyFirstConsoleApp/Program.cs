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

            Console.ReadKey();
        }
    }
}
