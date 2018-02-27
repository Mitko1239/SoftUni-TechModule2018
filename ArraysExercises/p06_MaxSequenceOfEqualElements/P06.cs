using System;
using System.Linq;

namespace p06_MaxSequenceOfEqualElements
{
    class P06
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;

                }
                else
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        numberMax = numbers[i];
                    }
                    counter = 1;
                }

                if (i + 1 == numbers.Length - 1)
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        numberMax = numbers[i];
                    }
                    counter = 1;
                }
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numberMax + " ");
            }
            Console.WriteLine();
        }
    }
}
