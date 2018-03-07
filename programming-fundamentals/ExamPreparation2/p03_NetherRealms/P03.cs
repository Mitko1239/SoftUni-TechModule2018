using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_NetherRealms
{
    class P03
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(n => n).ToList();
            string numbersPattern = @"[-+]?(\d+\.)?\d+";
            string lettersPattern = @"[^\d+\-*\/.]";

            double damage = 0.0;
            double health = 0.0;
            string name = "";

            for (int i = 0; i < input.Count; i++)
            {
                name = input[i];
                damage = Regex.Matches(input[i], numbersPattern).Cast<Match>().Select(d => double.Parse(d.Value)).Sum();
                health = Regex.Matches(input[i], lettersPattern).Cast<Match>()
                    .Select(h => (int) char.Parse(h.Value)).Sum();

                var multiplyCount = input[i].Count(m => m == '*');
                var delenie = input[i].Count(m => m == '/');

                if (multiplyCount > 0)
                {
                    damage *= Math.Pow(2, multiplyCount);
                }

                if (delenie > 0)
                {
                    damage /= Math.Pow(2, delenie);
                }

                Console.WriteLine($"{name} - {health} health, {damage:F2} damage");
            }
        }
    }
}