using System;
using System.Globalization;
using System.Numerics;

namespace p01_SinoTheWalker
{
    class P01
    {
        static void Main(string[] args)
        {
            DateTime departureTime =
                DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            int stepsTaken = int.Parse(Console.ReadLine());
            int timePerStep = int.Parse(Console.ReadLine());

            BigInteger seconds = ((BigInteger)(stepsTaken * timePerStep))%86400;
            departureTime = departureTime.AddSeconds((int)seconds);

            Console.WriteLine($"Time Arrival: {departureTime:HH:mm:ss}");
        }
    }
}
