using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace p03_EnduranceRally
{
    class P03
    {
        static void Main(string[] args)
        {
/*
Garry Clark
69 1 15 5
1 2

*/
            string[] drivers = Console.ReadLine().Split().ToArray();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

//            List<double> checkpoints = new List<double>();
//            Dictionary<string, List<double>> participants = new Dictionary<string, List<double>>();
//            for (int i = 0; i < checkpointIndexes.Length; i++)
//            {
//                checkpoints.Add(zones[checkpointIndexes[i]]);
//            }

            foreach (var driver in drivers)
            {
                double fuel = (int) driver.First();

                for (int i = 0; i < zones.Length; i++)
                {
                    double currentZoneFuel = zones[i];

                    if (checkpoints.Contains(i))
                    {
                        fuel += currentZoneFuel;
                    }
                    else
                    {
                        fuel -= currentZoneFuel;
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
            }
        }
    }
}