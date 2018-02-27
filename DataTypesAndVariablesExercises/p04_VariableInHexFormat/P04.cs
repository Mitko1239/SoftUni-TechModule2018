using System;

namespace p04_VariableInHexFormat
{
    class P04
    {
        static void Main(string[] args)
        {
            string inputHex = Console.ReadLine();
            int output = Convert.ToInt32(inputHex, 16);

            Console.WriteLine(output);
        }
    }
}
