using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_FixEmails
{
    class P04
    {
        static void Main(string[] args)
        {
            var mailbook = new Dictionary<string, string>();
            string name = "";
            string email = "";
            string commands = Console.ReadLine();

            while(commands != "stop")
            {
                name = commands;
                email = Console.ReadLine();
                if (!mailbook.ContainsKey(name))
                {
                    mailbook.Add(name, email);
                }

                commands = Console.ReadLine();
            }

            foreach (var entry in mailbook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
