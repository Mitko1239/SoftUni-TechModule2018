using System;
using System.Linq;
using System.Numerics;

namespace p01_ConvertFromBase10ToBaseN
{
    class P01
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(input[0]);
            BigInteger number = new BigInteger();
            number = BigInteger.Parse(input[1]);
            BigInteger remainder;
            string result = string.Empty;

            while (number > 0)
            {
                remainder = number % n;
                number /= n;
                result = remainder.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
