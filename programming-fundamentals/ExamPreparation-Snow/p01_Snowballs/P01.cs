using System;
using System.Numerics;

namespace p01_Snowballs
{
    class P01
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = -1;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowBallValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (currentSnowBallValue > maxValue)
                {
                    maxValue = currentSnowBallValue;
                    result = $"{snowballSnow} : {snowballTime} = {currentSnowBallValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(result);
        }
    }
}