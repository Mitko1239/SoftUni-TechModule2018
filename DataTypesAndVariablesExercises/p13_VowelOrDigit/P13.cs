using System;
using System.ComponentModel.DataAnnotations;

namespace p13_VowelOrDigit
{
    class P13
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' ||symbol == 'e' || symbol == 'o' || symbol == 'i' || symbol == 'y' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            } else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
