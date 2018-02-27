using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_PopulationCounter
{
    class P07
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|').ToArray();
            string country;
            string city;
            long population = 0;

            while (input[0] != "report")
            {
                country = input[1];
                city = input[0];
                population = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    var currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);
                    countries.Add(country, currentCity);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var pair in countries.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var cityPair in pair.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }
        }
    }
}
