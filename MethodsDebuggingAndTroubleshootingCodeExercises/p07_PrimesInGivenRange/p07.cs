using System;
using System.Collections.Generic;

namespace p07_PrimesInGivenRange
{
    class P07
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> numbers = FindPrimesInRange(startNum, endNum);
            int lastNum = numbers[numbers.Count - 1];
            foreach (int number in numbers)
            {
                if (number != lastNum)
                {
                    Console.Write($"{number}, ");
                }
                else {
                    Console.Write($"{number}");
                }
            }
            Console.WriteLine();
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> numbers = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        static bool IsPrime(long numberToCheck)
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
