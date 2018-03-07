using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace p03_RageQuit
{
    class Program2
    {
        static void Main2(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"([\D]+)([\d]+)";
            string result = "";
            List<char> uniqueSymbols = new List<char>();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string symbols = match.Groups[1].Value;
                foreach (var symbol in symbols)
                {
                    uniqueSymbols.Add(symbol);
                }

                int numberOfRepeats = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < numberOfRepeats; i++)
                {
                    result += symbols;
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Distinct().Count()}");
            Console.WriteLine(string.Join("", uniqueSymbols.Distinct()));
//            foreach (var s in result.ToString().Distinct())
//            {
//                Console.WriteLine(s);
//            }
//            Console.WriteLine(result);
        }
    }
}