using System;

namespace p05_FibonacciNumbers
{
    class P05
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));
        }

        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
