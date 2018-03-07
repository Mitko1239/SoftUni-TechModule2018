using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Snowmen
{
    class P02
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers.Count)
                {
                    numbers[i] %= numbers.Count;
                }

                int difference = Math.Abs(numbers[i] - i);
                int winner = 0;
                if (numbers[i] == i)
                {
                    Console.WriteLine($"{i} performed harakiri");
                }
                else
                {
                    if (difference % 2 == 0)
                    {
                        winner = i;
                    }
                    else if (difference % 2 == 1)
                    {
                        winner = numbers[i];
                    }
                    Console.WriteLine($"{i} * {numbers[i]} -> {winner} wins!");
                }

            }
        }
    }
}