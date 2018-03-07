using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_SoftUniKaraoke
{
    class P02
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
            List<string> songs = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim()).ToList();

            string performance;
            Dictionary<string, List<string>> allAwards = new Dictionary<string, List<string>>();

            while ((performance = Console.ReadLine()) != "dawn")
            {
                string[] tokens = performance.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim()).ToArray();

                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (!participants.Contains(name) || !songs.Contains(song))
                {
                    continue;
                }

                if (!allAwards.ContainsKey(name))
                {
                    allAwards.Add(name, new List<string>() {award});
                }
                else
                {
                    if (!allAwards[name].Contains(award))
                    {
                        allAwards[name].Add(award);
                    }
                }
            }

            if (allAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var participant in allAwards.OrderByDescending(a => a.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                foreach (var award in participant.Value.OrderBy(a=>a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}