using System;

namespace p04_NumbersInReverseOrder
{
    class P04
    {
        static void Main(string[] args)
        {
            char input = (char)Console.Read();
            string reversed = "";
            string normal = "";

            while (input != '\r')
            {
                normal += input;
                reversed = input + reversed;

                input = (char)Console.Read();
            }

            Console.WriteLine(reversed);
        }
    }
}
