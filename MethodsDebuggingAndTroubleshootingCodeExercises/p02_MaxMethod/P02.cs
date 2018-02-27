using System;

namespace p02_MaxMethod
{
    class P02
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(Math.Max(firstNumber, secondNumber), Math.Max(secondNumber, thirdNumber)));
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
