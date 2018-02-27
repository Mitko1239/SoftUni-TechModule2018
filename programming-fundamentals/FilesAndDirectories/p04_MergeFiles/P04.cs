using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace p04_MergeFiles
{
    class P04
    {
        static void Main(string[] args)
        {
            string input1 = @"../LabResources/04. Merge Files/FileOne.txt";
            string input2 = @"../LabResources/04. Merge Files/FileTwo.txt";
            string outputFile = "merged-file.txt";

            string[] file1 = File.ReadAllText(input1).Split(Environment.NewLine);
            string[] file2 = File.ReadAllText(input2).Split(Environment.NewLine);
            List<string> mergedFile = new List<string>();
            mergedFile.AddRange(file1);
            mergedFile.AddRange(file2);
            foreach (var line in mergedFile.OrderBy(x=>x))
            {
                File.AppendAllText(outputFile, line + Environment.NewLine);
            }
        }
    }
}
