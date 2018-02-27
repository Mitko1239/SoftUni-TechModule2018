using System;

namespace p11_OddNumber
{
    class P11
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = Math.Abs(int.Parse(Console.ReadLine()));
                if(num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                } else
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
            }

        }
    }
}
