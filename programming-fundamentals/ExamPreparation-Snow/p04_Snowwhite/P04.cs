using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Snowwhite
{
    class P04
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            string line;
            Dictionary<string, string> colors = new Dictionary<string, string>();
            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = line.Split(new [] {" <:> "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                int dwarfPhysics = int.Parse(tokens[2]);

                if (!colors.ContainsKey(dwarfHatColor))
                {
                    colors.Add(dwarfHatColor);   
                }

                string currentDwarfId = $"{dwarfName} <:> {dwarfHatColor}";
                if (dwarfs.ContainsKey(currentDwarfId))
                {
                    dwarfs.Add(currentDwarfId, dwarfPhysics);
                }
                else
                {
                    int oldValue = dwarfs[currentDwarfId];
                    if (dwarfPhysics > oldValue)
                    {
                        dwarfs[currentDwarfId] = dwarfPhysics;
                    }
                }

            }
        }
    }
}