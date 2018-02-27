using System;

namespace p03_UnicodeCharacters
{
    class P03
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write("\\u{0:x4}", (int)symbol);
            }
            Console.WriteLine();
        }
    }
}
