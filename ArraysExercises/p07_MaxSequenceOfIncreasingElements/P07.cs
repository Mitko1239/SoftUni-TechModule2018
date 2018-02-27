using System;
using System.Linq;

namespace p07_MaxSequenceOfIncreasingElements
{
    class P07
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int position = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i + 1;
                    }
                }
                else
                {
                    counter = 1;
                }

            }
            int[] result = new int[counterMax];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = numbers[position - counterMax + 1];
                position++;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
