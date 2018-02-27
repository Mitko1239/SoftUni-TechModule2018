using System;

namespace p10_CubeProperties
{
    class P10
    {
        static void Main(string[] args)
        {
            double sideLength = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
            {
                Console.WriteLine($"{FaceOfCube(sideLength):f2}");
            }
            else if (parameter == "space")
            {
                Console.WriteLine($"{SpaceOfCube(sideLength):f2}");
            }
            else if (parameter == "volume")
            {
                Console.WriteLine($"{VolumeOfCube(sideLength):f2}");
            }
            else if (parameter == "area")
            {
                Console.WriteLine($"{SurfaceOfCube(sideLength):f2}");
            }
        }

        static double FaceOfCube(double num)
        {
            double diagonalSize = Math.Sqrt(2 * num * num);
            return diagonalSize;
        }

        static double SpaceOfCube(double num)
        {
            double spaceSize = Math.Sqrt(3 * num * num);
            return spaceSize;
        }

        static double VolumeOfCube(double num)
        {
            double VolumeSize = num * num * num;
            return VolumeSize;
        }

        static double SurfaceOfCube(double num)
        {
            double surfaceSize = 6 * (num * num);
            return surfaceSize;
        }
    }
}