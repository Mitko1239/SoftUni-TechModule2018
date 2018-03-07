using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<List<string>, long>> data =
                new Dictionary<string, Dictionary<List<string>, long>>();

            string[] info = Console.ReadLine()
                .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);


            while (info[0] != "wubbalubbadubdub")
            {
                string name = info[0];

                if (info.Length == 1)
                {
                    if (data.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var item in data[name])
                        {
                            Console.WriteLine($"{string.Join(" ", item.Key)} <-> {item.Value}");
                        }
                    }
                }
                else
                {
                    List<string> type = new List<string>();
                    type.Add(info[1]);
                    long index = long.Parse(info[2]);

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<List<string>, long>());
                    }

                    if (!data[name].ContainsKey(type))
                    {
                        data[name].Add(type, index);
                    }

                    if (!data[name].ContainsValue(index))
                    {
                        data[name][type] = index;
                    }
                }

                info = Console.ReadLine()
                    .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in data)
            {
                Console.WriteLine($"# {item.Key}");

                foreach (var itemm in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{string.Join(" ", itemm.Key)} <-> {itemm.Value}");
                }
            }
        }
    }
}