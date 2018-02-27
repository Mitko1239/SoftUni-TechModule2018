using System;

namespace p06_NumberTable
{
    class P06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int final = j + (i - 1) % n;
                    if(final > n)
                    {
                        final -= i;
                    }
                    Console.Write($"{final} ");
                }
                Console.WriteLine();
            }
        }
    }
}
