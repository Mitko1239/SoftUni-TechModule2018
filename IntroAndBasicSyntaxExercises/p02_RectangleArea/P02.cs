using System;

namespace p02_RectangleArea
{
    class P02
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double area = sideA * sideB;

            Console.WriteLine($"{area:f2}");
        }
    }
}
