using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace p03_CountOfSymbols
{
    class P03
    {
        static void Main(string[] args)
        {
            string inputFile = @"../ExercisesResources/03. Count of Symbols/input.txt";
            string outputFile = "output.txt";
            List<string> sentence = File.ReadAllText(inputFile).Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<char, int> occurances = new Dictionary<char, int>();

            foreach (var word in sentence)
            {
                foreach (var symbol in word)
                {
                    if (!occurances.ContainsKey(symbol))
                    {
                        occurances.Add(symbol, 1);
                    }
                    else
                    {
                        occurances[symbol]++;
                    }
                }
            }
            foreach (var occurance in occurances.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(outputFile, $"{occurance.Key} -> {occurance.Value}" + Environment.NewLine);
            }
        }
    }
}