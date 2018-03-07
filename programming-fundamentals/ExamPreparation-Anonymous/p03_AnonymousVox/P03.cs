using System;
using System.Text.RegularExpressions;

namespace p03_AnonymousVox
{
    class P03
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] placeholder = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"([A-Za-z]+)(.*)(\1)";
            var matches = Regex.Matches(encodedText, pattern);

            int count = 0;

            foreach (Match match in matches)
            {
                string decodedMessage = match.Groups[1] + placeholder[count++] + match.Groups[3];
                encodedText = encodedText.Replace(match.Value, decodedMessage);
            }

            Console.WriteLine(encodedText);
        }
    }
}
