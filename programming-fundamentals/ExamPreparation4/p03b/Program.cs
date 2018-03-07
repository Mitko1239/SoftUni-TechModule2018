using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03b
{
    class Program
    {
        static void Main(string[] args)
        {
            string decryptKey = Console.ReadLine();
            string pattern = $@"([{decryptKey}]+)(\w+)(\1)";
            Regex regex = new Regex(pattern);
            Dictionary<string, List<int>> leagueStandings = new Dictionary<string, List<int>>();
            string line;
            while ((line = Console.ReadLine()) != "final")
            {
                string[] split = line.Split().ToArray();
                MatchCollection matches = regex.Matches(line);
                foreach (Match match in matches)
                {
                    string countryName = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());
                    if (!leagueStandings.ContainsKey(countryName))
                    {
                        leagueStandings.Add(countryName, new List<int>() {0, 0});
                    }
                }

                string country1Name = new string(matches[0].Groups[2].Value.ToUpper().Reverse().ToArray());
                string country2Name = new string(matches[1].Groups[2].Value.ToUpper().Reverse().ToArray());

                int[] result = split[2].Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                if (result[0] > result[1])
                {
                    leagueStandings[country1Name][0] += 3;
                    leagueStandings[country1Name][1] += result[0];
                    leagueStandings[country2Name][1] += result[1];
                }
                else if (result[1] > result[0])
                {
                    leagueStandings[country2Name][0] += 3;
                    leagueStandings[country1Name][1] += result[0];
                    leagueStandings[country2Name][1] += result[1];
                }
                else if (result[0] == result[1])
                {
                    leagueStandings[country1Name][0] += 1;
                    leagueStandings[country1Name][1] += result[0];
                    leagueStandings[country2Name][0] += 1;
                    leagueStandings[country2Name][1] += result[1];
                }
            }

            Console.WriteLine("League standings:");
            int count = 1;
            foreach (var standing in leagueStandings.OrderByDescending(x => x.Value[0]))
            {
                Console.WriteLine($"{count++}. {standing.Key} {standing.Value[0]}");
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var standing in leagueStandings.OrderByDescending(x => x.Value[1]).Take(3))
            {
                Console.WriteLine($"- {standing.Key} -> {standing.Value[1]}");
            }
        }
    }
}
