using System;

namespace p03_GreatestCommonDivisor
{
    class P03
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int gcd = 0;

            for (int i = Math.Min(a, b); i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                    break;
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
