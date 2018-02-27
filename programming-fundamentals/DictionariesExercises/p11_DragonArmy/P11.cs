using System;
using System.Collections.Generic;
using System.Linq;

namespace p11_DragonArmy
{
    class P11
    {
        static void Main(string[] args)
        {
            int numberOfLogs = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            for (int i = 0; i < numberOfLogs; i++)
            {
                string[] logInput = Console.ReadLine().Split().ToArray();
                string type = logInput[0];
                string name = logInput[1];
                int damage = 45;
                int health = 250;
                int armor = 10;
                if (logInput[2] != "null")
                {
                    damage = int.Parse(logInput[2]);
                }
                if (logInput[3] != "null")
                {
                    health = int.Parse(logInput[3]);
                }
                if (logInput[4] != "null")
                {
                    armor = int.Parse(logInput[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    var dragon = new Dictionary<string, List<int>>();
                    dragon.Add(name, new List<int> { damage, health, armor });
                    dragons.Add(type, dragon);
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new List<int> { damage, health, armor });
                    }
                    else
                    {
                        dragons[type][name][0] = damage;
                        dragons[type][name][1] = health;
                        dragons[type][name][2] = armor;
                    }
                }
            }

            foreach (var dragonType in dragons)
            {
                double averageDamage = dragonType.Value.Select(x => x.Value[0]).Average();
                double averageHealth = dragonType.Value.Select(x => x.Value[1]).Average();
                double averageArmor = dragonType.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{dragonType.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");
                foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
