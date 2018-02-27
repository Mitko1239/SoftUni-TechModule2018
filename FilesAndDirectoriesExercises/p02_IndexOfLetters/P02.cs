using System;
using System.IO;

namespace p02_IndexOfLetters
{
    class P02
    {
        static void Main(string[] args)
        {
            string inputFile = @"../ExercisesResources/02. Index Of Letters/input.txt";
            string outputFile = "output.txt";

            string word = File.ReadAllText(inputFile);

            foreach (var character in word)
            {
                File.AppendAllText(outputFile, $"{character} -> {(int)character - 97}" + Environment.NewLine);
            }
        }
    }
}
