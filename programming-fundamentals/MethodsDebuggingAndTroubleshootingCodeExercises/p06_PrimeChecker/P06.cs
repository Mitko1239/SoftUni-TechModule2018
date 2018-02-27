using System;

namespace p06_PrimeChecker
{
    class P06
    {
        static void Main(string[] args)
        {
            long numberToCheck = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(numberToCheck));
        }

        static bool isPrime(long numberToCheck)
        {
            if (numberToCheck <= 1)
            {
                return false;
            }
            else if (numberToCheck % 2 == 0)
            {
                return numberToCheck == 2;
            }
            long N = (long)(Math.Sqrt(numberToCheck) + 0.5);

            for (int i = 3; i <= N; i += 2)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
