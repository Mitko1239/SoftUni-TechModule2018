using System;

namespace p01_HelloName
{
    class P01
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        private static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
