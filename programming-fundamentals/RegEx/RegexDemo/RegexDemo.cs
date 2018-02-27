using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class RegexDemo
    {
        static void Main(string[] args)
        {
            string text = "22-JAN-2017";
            //string input = Console.ReadLine();
            //string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string pattern = @"(?<day>\d+)(?<delimeter>[-|\/])(?<month>\w+)(\k<delimeter>)(?<year>\d{2,4})";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (var match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();






            //string text = "22-JAN-2017";
            //string pattern = @"(?<day>\d+)(?<delimeter>[-|\/])(?<month>\w+)(\g<delimeter>)(?<year>\d{2,4})";

            //Regex regex = new Regex(pattern);

            //Match match = regex.Match(text);
            //string day = match.Groups[1].Value;
            //string month = match.Groups[3].Value;
            //string year = match.Groups[5].Value;
            //Console.WriteLine(match.Groups["day"]);
        }
    }
}
