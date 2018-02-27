using System;

namespace p17_PrintPartOfTheAsciiTable
{
    class P17
    {
        static void Main(string[] args)
        {
            int tableStart = int.Parse(Console.ReadLine());
            int tableEnd = int.Parse(Console.ReadLine());
            char symbol;

            for (int i = tableStart; i <= tableEnd; i++)
            {
                symbol = (char)i;
                Console.Write($"{symbol} ");
            }
            Console.WriteLine();
        }
    }
}
