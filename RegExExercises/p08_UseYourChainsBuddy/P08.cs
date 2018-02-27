using System;
using System.Text;
using System.Text.RegularExpressions;

namespace p08_UseYourChainsBuddy
{
    class P08
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=<p>).*?(?=<\/p>)";
            Regex regex = new Regex(pattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match match in regex.Matches(input))
            {
                var replaced = Regex.Replace(match.ToString(), "[^a-z0-9]", " ");
                for (var i = 0; i < replaced.Length; i++)
                {
                    char ch = replaced[i];
                    if (char.IsLower(replaced[i]))
                    {
                        if (replaced[i] < 110)
                        {
                            sb.Append((char)(ch + 13));
                        }
                        else if (replaced[i] >= 110)
                        {
                            sb.Append((char)(ch - 13));
                        }
                    }
                    else
                    {
                        sb.Append(replaced[i]);
                    }
                }
            }
            Console.WriteLine(Regex.Replace(sb.ToString(), "\\s+", " "));
        }
    }
}
