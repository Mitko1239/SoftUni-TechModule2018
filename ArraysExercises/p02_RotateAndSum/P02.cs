using System;
using System.Linq;

namespace p02_RotateAndSum
{
    class P02
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                numbers = Rotate(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        static int[] Rotate(int[] numbers)
        {
            int[] rotated = new int[numbers.Length];
            int last = numbers[numbers.Length - 1];
            for (int i = 1; i < rotated.Length; i++)
            {
                rotated[i] = numbers[i - 1];
            }
            rotated[0] = last;

            return rotated;
        }
    }
}
