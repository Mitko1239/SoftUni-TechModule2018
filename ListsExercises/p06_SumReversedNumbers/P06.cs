using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SumReversedNumbers
{
    class P06
    {
        static void Main(string[] args)
        {
            //Variant 1
            /*
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                int reversed = 0;
                while (number > 0)
                {

                    int remainder = number % 10;
                    reversed = (reversed * 10) + remainder;
                    number = number / 10;
                }
                numbers[i] = reversed;
                sum += numbers[i];
            }
            Console.WriteLine(string.Join(" ", sum));
            */
            //Variant 2???
            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int sum = 0;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    List<char> num = numbers[i].ToString().ToList();
            //    num.Reverse();
            //    sum += int.Parse(string.Join("",num));
            //    numbers.Add(int.Parse(string.Join("", num)));
            //}
            //numbers.RemoveRange(0, numbers.Count / 2);
            //Console.WriteLine(sum);
            //Variant 3
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            int count = numbers.Count;
            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> num = numbers[i].ToString().ToList();
                num.Reverse();
                numbers.Add(int.Parse(string.Join("", num)));
            }
            numbers.RemoveRange(0, count);
            Console.WriteLine(numbers.Sum());
        }
    }
}