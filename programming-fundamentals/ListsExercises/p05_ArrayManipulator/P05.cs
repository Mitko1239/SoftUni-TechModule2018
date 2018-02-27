using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ArrayManipulator
{
    class P05
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();

            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    int element = int.Parse(commands[2]);
                    int position = int.Parse(commands[1]);
                    numbers.Insert(position, element);
                }
                else if (commands[0] == "addMany")
                {
                    int index = int.Parse(commands[1]);
                    numbers.InsertRange(index, commands.Skip(2).Select(int.Parse));
                }
                else if (commands[0] == "contains")
                {
                    if (numbers.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine(numbers.IndexOf(int.Parse(commands[1])));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (commands[0] == "remove")
                {
                    int position = int.Parse(commands[1]);
                    numbers.RemoveAt(position);
                }
                else if (commands[0] == "shift")
                {
                    int position = int.Parse(commands[1]) % numbers.Count;
                    var helper = numbers.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        helper.Add(numbers[i]);
                    }
                    numbers = helper;
                }
                else if (commands[0] == "sumPairs")
                {
                    int cycles = numbers.Count / 2;
                    for (int i = 0; i < cycles; i++)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
