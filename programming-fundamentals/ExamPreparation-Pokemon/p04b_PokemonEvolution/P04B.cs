using System;
using System.Collections.Generic;
using System.Linq;

namespace p04b_PokemonEvolution
{
    class P04B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {'-', '>', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string name = "";
            string evolution = "";
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            while (input[0] != "wubbalubbadubdub")
            {
                if (input.Length > 1)
                {
                    name = input[0];
                    evolution = input[1] + " <-> " + input[2];
                    if (!pokemons.ContainsKey(name))
                    {
                        List<string> currentList = new List<string>() {evolution};
                        pokemons.Add(name, currentList);
                    }
                    else
                    {
                        pokemons[name].Add(evolution);
                    }
                }
                else
                {
                    name = input[0];
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var evo in pokemons[name])
                        {
                            Console.WriteLine($"{evo}");
                        }
                    }
                }

                input = Console.ReadLine().Split(new char[] {'-', '>', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var pair in pokemons)
            {
                Console.WriteLine($"# {pair.Key}");
                foreach (var ev in pair.Value.OrderByDescending(x => int.Parse(x
                    .Split(new char[] {'<', '-', '>', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1).First()
                )))
                {
                    Console.WriteLine($"{ev}");
                }
            }
        }
    }
}