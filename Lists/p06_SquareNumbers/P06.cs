using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SquareNumbers
{
    class P06
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            List<int> selected = numbers
                .Where(num =>
                Math.Sqrt(num) == (int)Math.Sqrt(num)
                ).ToList();

            Console.WriteLine(string.Join(" ", selected));
        }
    }
}
