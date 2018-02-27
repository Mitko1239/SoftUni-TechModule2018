using System;
using System.Linq;

namespace p09_IndexOfLetters
{
    class P09
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] letters = word.ToCharArray();
            char[] alphabet = new char[26];
            char firstLetter = 'a';
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = firstLetter;
                firstLetter++;
            }
            //Console.WriteLine(string.Join(" ", letters));

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (letters[i] == alphabet[j])
                    {
                        Console.WriteLine($"{letters[i]} -> {j}");
                    }
                }
            }
        }
    }
}
