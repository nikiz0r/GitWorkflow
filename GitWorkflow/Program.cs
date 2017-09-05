using System;

namespace GitWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, type your name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");

            Console.ReadKey();
        }
    }
}
