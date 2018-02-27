using System;
using System.IO;

namespace p02_LineNumbers
{
    class P02
    {
        static void Main(string[] args)
        {
            string inputFile = @"../LabResources/02. Line Numbers/Input.txt";
            string outputFile = "line-numbers.txt";

            string[] lines = File.ReadAllLines(inputFile);
            for (int i = 0; i < lines.Length; i++)
            {
                File.AppendAllText(outputFile, i + 1 + ". " + lines[i] + Environment.NewLine);
            }
        }
    }
}