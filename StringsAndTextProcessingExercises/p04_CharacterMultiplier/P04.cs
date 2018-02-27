﻿using System;
using System.Linq;

namespace p04_CharacterMultiplier
{
    class P04
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string w1 = input[0];
            string w2 = input[1];
            int sum = 0;

            for (int i = 0; i < Math.Min(w1.Length, w2.Length); i++)
            {
                sum += w1[i] * w2[i];
            }

            for (int i = Math.Min(w1.Length, w2.Length); i < Math.Max(w1.Length, w2.Length); i++)
            {
                try
                {
                    sum += w1[i];
                }
                catch (Exception)
                {

                    sum += w2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
