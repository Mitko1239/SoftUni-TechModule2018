using System;

namespace p09_ReverseCharacters
{
    class P09
    {
        static void Main(string[] args)
        {
            char letterA = char.Parse(Console.ReadLine());
            char letterB = char.Parse(Console.ReadLine());
            char letterC = char.Parse(Console.ReadLine());

            Console.WriteLine($"{letterC}{letterB}{letterA}");
        }
    }
}
