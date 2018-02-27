using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace p03_WordCount
{
    class P03
    {
        static void Main(string[] args)
        {
            string inputText = @"../LabResources/03. Word Count/text.txt";
            string inputWords = @"../LabResources/03. Word Count/words.txt";
            string outputFile = "occurances.txt";

            string[] words = File.ReadAllText(inputWords).ToLower().Split();
            string[] text = File.ReadAllText(inputText).ToLower()
                .Split(new char[] {'\n', '\r', ' ', ',', '.', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                wordCount[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            foreach (var entry in wordCount.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(outputFile, $"{entry.Key} -> {entry.Value}"+Environment.NewLine);
            }
        }
    }
}