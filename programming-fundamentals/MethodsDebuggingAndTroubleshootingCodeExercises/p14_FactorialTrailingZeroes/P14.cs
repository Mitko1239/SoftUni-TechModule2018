using System;
using System.Numerics;

namespace p14_FactorialTrailingZeroes
{
    class P14
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{TrailingZeroes(Factorial(number))}");
        }

        static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static int TrailingZeroes(BigInteger factorial)
        {
            int trailingZeroes = 0;

            while (factorial % 10 == 0)
            {
                trailingZeroes++;
                factorial /= 10;
            }

            return trailingZeroes;
        }
    }
}
