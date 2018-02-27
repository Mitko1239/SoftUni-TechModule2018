using System;
using System.Collections.Generic;

namespace ListsDemo
{
    class ListsDemo
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int cycles = numbers.Count;
            for (int i = 0; i < cycles - 1; i++)
            {
                numbers.RemoveAt(0);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
