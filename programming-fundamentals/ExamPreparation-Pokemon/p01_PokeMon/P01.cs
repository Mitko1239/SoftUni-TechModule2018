using System;

namespace p01_PokeMon
{
    class P01
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int originalPower = 0;
            int count = 0;
            originalPower = power;

            while (power > distance)
            {
                power -= distance;
                count++;

                if (power == originalPower / 2)
                {
                    power /= exhaustionFactor;
                }
                else
                {
                    power -= distance;
                    count++;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}