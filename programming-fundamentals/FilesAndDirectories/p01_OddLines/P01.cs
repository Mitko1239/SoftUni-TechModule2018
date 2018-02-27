using System;
using System.IO;
using System.Linq;

namespace p01_OddLines
{
    class P01
    {
        static void Main(string[] args)
        {
            string inputFile = @"../LabResources/01. Odd Lines/Input.txt";
            string outputFile = "odd-lines.txt";

            string[] lines = File.ReadAllLines(inputFile);
            var oddLines = lines.Where((line, index) => index % 2 == 1).ToList();
            File.WriteAllText(outputFile, string.Join(Environment.NewLine, oddLines));
        }
    }
}