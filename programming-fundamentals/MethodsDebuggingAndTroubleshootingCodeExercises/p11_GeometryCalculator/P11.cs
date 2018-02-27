using System;

namespace p11_GeometryCalculator
{
    class P11
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{TriangleArea(side, height):f2}");
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{SquareArea(side):f2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{RectangleArea(width, height):f2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CircleArea(radius):f2}");
            }
        }

        private static object TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        private static object SquareArea(double side)
        {
            double area = Math.Pow(side, 2);
            return area;
        }

        private static object RectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
