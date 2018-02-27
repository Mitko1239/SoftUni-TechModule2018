using System;

namespace p04_SieveOfEratosthenes
{
    class P04
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[range+1];

            for (int i = 0; i <= range; i++)
            {
                isPrime[i] = true;
            }
            isPrime[0] = isPrime[1] = false;
            for (int p = 2; p <= range; p++)
            {
                if (isPrime[p])
                {
                    Console.Write($"{p} ");
                    for (int j = 2; (j * p) <= range; j++)
                    {
                        isPrime[j * p] = false;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}