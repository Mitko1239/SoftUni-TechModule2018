using System;

namespace p01b_PokeMon_ProperSolution
{
    class P01B
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int currentPower = power;
            int counter = 0;

            while (currentPower >= distance)
            {
                currentPower -= distance;
                counter++;
                if (currentPower == power / 2 && power % 2 == 0 && exhaustionFactor != 0)
                {
                    currentPower /= exhaustionFactor;
                }
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(counter);
        }
    }
}