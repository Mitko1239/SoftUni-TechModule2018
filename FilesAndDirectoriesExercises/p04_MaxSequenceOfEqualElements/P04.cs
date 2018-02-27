using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace p04_MaxSequenceOfEqualElements
{
    class P04
    {
        static void Main(string[] args)
        {
            string inputFile = @"../ExercisesResources/04. Max Sequence of Equal Elements/input.txt";
            string outputFile = "output.txt";
            string[] lines = File.ReadAllText(inputFile).Split(Environment.NewLine).ToArray();

            foreach (var line in lines)
            {
                int counter = 1;
                int counterMax = 0;
                int numberMax = 0;
                List<int> numbers = line.Split(' ').Select(int.Parse).ToList();
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter > counterMax)
                        {
                            counterMax = counter;
                            numberMax = numbers[i];
                        }

                        counter = 1;
                    }

                    if (i + 1 == numbers.Count - 1)
                    {
                        if (counter > counterMax)
                        {
                            counterMax = counter;
                            numberMax = numbers[i];
                        }
                    }
                }

                for (int i = 0; i < counterMax; i++)
                {
                    File.AppendAllText(outputFile, numberMax + " ");
                }
                File.AppendAllText(outputFile, Environment.NewLine);
            }
        }
    }
}
