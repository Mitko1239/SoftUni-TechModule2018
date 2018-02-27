using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_MinerTask
{
    class P03
    {
        static void Main(string[] args)
        {
            string commands = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            string metal = "";
            int quantity = 0;

            while(commands != "stop")
            {
                metal = commands;
                quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(metal))
                {
                    resources.Add(metal, quantity);
                }
                else
                {
                    resources[metal] += quantity;
                }
                commands = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
