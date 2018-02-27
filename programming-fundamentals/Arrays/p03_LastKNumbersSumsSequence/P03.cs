using System;

namespace p03_LastKNumbersSumsSequence
{
    class P03
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            arr[0] = 1;
            for (int i = 1; i < length; i++)
            {
                int sum = 0;
                int counter = 0;
                for (int j = i; j >= 0; j--)
                {
                    sum += arr[j];
                    counter++;
                    if (counter > count)
                    {
                        break;
                    }
                }
                arr[i] = sum;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
