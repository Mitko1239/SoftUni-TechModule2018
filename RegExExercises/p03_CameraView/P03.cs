using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_CameraView
{
    class P03
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toSkip = numbers[0];
            int toTake = numbers[1];

            string input = Console.ReadLine();
            string pattern = @"\|<([\w]{" + toSkip + @"})([\w]{0," + toTake + @"})";

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add(match.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
