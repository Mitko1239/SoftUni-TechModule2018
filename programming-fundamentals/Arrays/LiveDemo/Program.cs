using System;
using System.Linq;

namespace LiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int size = int.Parse(Console.ReadLine());

            //int[] numbers = new int[size];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Reverse(numbers);
            //Console.WriteLine(string.Join(' ', numbers));

            double[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (double num in numbers)
            {
                var rounded = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {rounded}");
            }
        }
    }
}
