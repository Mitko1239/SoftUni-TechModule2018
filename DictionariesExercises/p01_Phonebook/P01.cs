using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_Phonebook
{
    class P01
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split().ToArray();
            var phonebook = new Dictionary<string, string>();

            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    string name = commands[1];
                    string phone = commands[2];
                    if (phonebook.ContainsKey(name) == false)
                    {
                        phonebook.Add(name, phone);
                    }
                    else
                    {
                        phonebook[name] = phone;
                    }
                }
                else if (commands[0] == "S")
                {
                    string name = commands[1];
                    if (phonebook.ContainsKey(name) != false)
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                commands = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
