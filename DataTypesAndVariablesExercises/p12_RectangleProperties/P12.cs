using System;

namespace p12_RectangleProperties
{
    class P12
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());
            double perimeter = (2 * rectangleWidth) + (2 * rectangleHeight);
            double area = rectangleWidth * rectangleHeight;
            double diagonal = Math.Sqrt(Math.Pow(rectangleWidth, 2) + Math.Pow(rectangleHeight, 2));

            Console.WriteLine($"{perimeter}");
            Console.WriteLine($"{area}");
            Console.WriteLine($"{diagonal}");
        }
    }
}
