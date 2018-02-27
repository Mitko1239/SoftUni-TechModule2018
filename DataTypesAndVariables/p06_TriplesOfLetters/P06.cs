using System;

namespace p06_TriplesOfLetters
{
    class P06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                char letterA = (char)('a' + i);
                Console.Write(letterA);
                for (int j = 0; j < n - 1; j++)
                {
                    char letterB = (char)('a' + j);
                    Console.Write(letterB);
                    for (int k = 0; k < n - 1; k++)
                    {
                        char letterC = (char)('a' + k);
                        Console.Write(letterC);
                        Console.WriteLine();
                        //char letterB = (char)('b' + j);
                        //char letterC = (char)('c' + i);
                        //Console.WriteLine($"{letterA}{letterB}{letterC}");
                    }
                }
            }

        }
    }
}
