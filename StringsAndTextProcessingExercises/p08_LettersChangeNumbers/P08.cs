using System;
using System.Linq;

namespace p08_LettersChangeNumbers
{
    class P08
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double totalSum = 0;

            foreach (var word in words)
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));
                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= (firstLetter - 64);
                }
                else
                {
                    number *= (firstLetter - 96);
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number -= (lastLetter - 64);
                }
                else
                {
                    number += (lastLetter - 96);
                }
                totalSum += number;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
