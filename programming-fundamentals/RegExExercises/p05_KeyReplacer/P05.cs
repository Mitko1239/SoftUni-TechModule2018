using System;
using System.Text;
using System.Text.RegularExpressions;

namespace p05_KeyReplacer
{
    class P05
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)([<\|\\])(.*)([<\|\\])([A-Za-z]+)";
            string input = Console.ReadLine();
            Match m = Regex.Match(input, pattern);
            string start = m.Groups[1].Value;
            string end = m.Groups[5].Value;
            string input2 = Console.ReadLine();
            string pattern2 = $@"{start}(.*?){end}";
            StringBuilder builder = new StringBuilder();

            MatchCollection results = Regex.Matches(input2, pattern2);
            foreach (Match result in results)
            {
                builder.Append(result.Groups[1].Value);
            }
            if(builder.Length > 0)
            {
                Console.WriteLine(builder);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
