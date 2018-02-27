using System;

namespace p02_CircleArea
{
    class P02
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            var circleArea = Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
