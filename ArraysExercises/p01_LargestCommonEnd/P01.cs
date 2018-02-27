using System;
using System.Linq;

namespace p01_LargestCommonEnd
{
    class P01
    {
        static void Main(string[] args)
        {
            string[] firstSentence = Console.ReadLine().Split(' ').ToArray();
            string[] secondSentence = Console.ReadLine().Split(' ').ToArray();
            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < Math.Min(firstSentence.Length, secondSentence.Length); i++)
            {
                if (firstSentence[i] == secondSentence[i])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < Math.Min(firstSentence.Length, secondSentence.Length); i++)
            {
                if (firstSentence[firstSentence.Length - 1 - i] == secondSentence[secondSentence.Length - 1 - i])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }

            if (leftCount > rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }


        }
    }
}
