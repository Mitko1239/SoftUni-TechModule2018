using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace p01_MostFrequentNumber
{
    class P01
    {
        static void Main(string[] args)
        {
            string inputFile = @"../ExercisesResources/01. Most Frequent Number/input.txt";
            string outputFile = "output.txt";

            string[] sequences = File.ReadAllText(inputFile).Split(Environment.NewLine).ToArray();
            foreach (var line in sequences)
            {
                List<int> numbers = line.Split().Select(int.Parse).ToList();
                Dictionary<int, int> occurances = new Dictionary<int, int>();
                foreach (var number in numbers)
                {
                    if (!occurances.ContainsKey(number))
                    {
                        occurances.Add(number, 1);
                    }
                    else
                    {
                        occurances[number]++;
                    }
                }

                foreach (var occurance in occurances.OrderByDescending(x=>x.Value).Take(1))
                {
                    File.AppendAllText(outputFile, $"{occurance.Key}" + Environment.NewLine);
                }
            }
        }
    }
}
