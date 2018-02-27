using System;

namespace p11_ConvertSpeedUnits
{
    class P11
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = seconds + minutes * 60 + hours * 3600;

            float metersPerSecond = (float)distance / time;
            float kilometersPerHour = ((float)distance/1000)/((float)time/3600);
            float milesPerHour = ((float)distance/1609)/((float)time/3600);

            Console.WriteLine($"{metersPerSecond:0.######}\r\n{kilometersPerHour:0.######}\r\n{milesPerHour:0.######}");
        }
    }
}
