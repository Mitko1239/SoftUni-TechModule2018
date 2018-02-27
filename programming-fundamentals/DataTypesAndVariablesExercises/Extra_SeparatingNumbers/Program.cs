using System;

namespace Extra_SeparatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    current = number % 10;
            //    Console.WriteLine(current);
            //    number /= 10;
            //}
            while(number > 0)
            {
                current = number % 10;
                Console.WriteLine(current);
                number /= 10;
            }
        }
    }
}
