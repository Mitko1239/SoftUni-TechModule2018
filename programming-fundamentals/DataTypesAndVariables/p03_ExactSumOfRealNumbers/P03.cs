using System;

namespace p03_ExactSumOfRealNumbers
{
    class P03
    {
        static void Main(string[] args)
        {
            int numbersAmount = int.Parse(Console.ReadLine());
            decimal sum = 0M;
            for (int i = 0; i < numbersAmount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
