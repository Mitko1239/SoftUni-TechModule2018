using System;
using System.Collections.Generic;
using System.IO;

namespace p05_FixEmails
{
    class P05
    {
        static void Main(string[] args)
        {
            string inputFile = @"../ExercisesResources/05. Fix Emails/input.txt";
            string outputFile = "output.txt";

            string[] lines = File.ReadAllLines(inputFile);

            var names = new List<string>();
            var emails = new List<string>();
            for (int i = 0; i < lines.Length; i += 2)
            {
                names.Add(lines[i]);
            }

            for (int i = 1; i < lines.Length; i += 2)
            {
                if (!lines[i].Contains(".us") && !lines[i].Contains(".uk"))
                {
                    emails.Add(lines[i]);
                }
            }

            for (int i = 0; i < Math.Min(names.Count, emails.Count); i++)
            {
                File.AppendAllText(outputFile, $"{names[i]} -> {emails[i]}" + Environment.NewLine);
            }
        }
    }
}