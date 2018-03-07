using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace p03_RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"([\D]+)([\d]+)";
            StringBuilder result = new StringBuilder();
            List<char> uniqueSymbols = new List<char>();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string symbols = match.Groups[1].Value;

                int numberOfRepeats = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < numberOfRepeats; i++)
                {
                    result.Append(symbols);
                }
            }

            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}