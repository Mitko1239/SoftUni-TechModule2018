using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_BombNumbers
{
    class P07
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bombNumber = commands[0];
            int power = commands[1];

            while (numbers.Contains(bombNumber))
            {
                int position = numbers.IndexOf(bombNumber);
                if (position - power < 0 && position + power > numbers.Count)
                {
                    numbers.Clear();
                }
                else if (position - power < 0)
                {
                    numbers.RemoveRange(0, 1 + power + position);
                }
                else if (position + power >= numbers.Count)
                {
                    numbers.RemoveRange(position - power, power - numbers.Count - position);
                }
                else
                {
                    numbers.RemoveRange(position - power, 2 * power + 1);
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
