using System;

namespace p16_ComparingFloats
{
    class P16
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            decimal eps = 0.000001M;
            decimal difference = Math.Max(firstNumber, secondNumber) - Math.Min(firstNumber, secondNumber);
            bool isEqual = false;

            if (difference < eps)
            {
                isEqual = true;
            }
            Console.WriteLine($"{isEqual}");
        }
    }
}
