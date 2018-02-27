using System;

namespace p14_IntToHexAndBinary
{
    class P14
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            string hexa = Convert.ToString(number, 16).ToUpper();

            Console.WriteLine($"{hexa}");
            Console.WriteLine($"{binary}");
        }
    }
}
