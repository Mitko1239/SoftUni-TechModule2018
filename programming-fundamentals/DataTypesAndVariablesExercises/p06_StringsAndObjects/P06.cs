using System;

namespace p06_StringsAndObjects
{
    class P06
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            object outputObject = firstString + " " + secondString;

            Console.WriteLine(outputObject);
        }
    }
}
