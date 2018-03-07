using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_AnonymousCache
{
    class P04
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                string[] split = input.Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (split.Length > 1)
                {
                    string dataKey = split[0];
                    long dataSize = long.Parse(split[1]);
                    string dataSet = split[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }

                    data[dataSet][dataKey] = dataSize;
                }

                input = Console.ReadLine();
            }

            if (data.Count > 1)
            {
                var dataSetWithMaxSize =
                    data.OrderByDescending(x => x.Value.Sum(d => d.Value)).First();
                Console.WriteLine(
                    $"Data Set: {dataSetWithMaxSize.Key}, Total Size: {dataSetWithMaxSize.Value.Sum(d => d.Value)}");
                foreach (var entry in dataSetWithMaxSize.Value)
                {
                    Console.WriteLine($"$.{entry.Key}");
                }
            }

        }
    }
}