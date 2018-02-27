using System;
using System.Text.RegularExpressions;

namespace p01_ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string emailPattern = @"(^|(?<=\s))([a-z0-9]+)([_\.-]?[a-z0-9])*@([a-z0-9])+([-.][a-z0-9]*)([a-z0-9]+)([-.][a-z0-9]+)*";

            MatchCollection matches = Regex.Matches(input, emailPattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
