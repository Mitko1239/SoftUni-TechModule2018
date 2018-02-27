using System;

namespace p04_BeverageLabels
{
    class P04
    {
        static void Main(string[] args)
        {
            string beverageName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double ratio = volume / 100.0;

            Console.WriteLine($"{volume}ml {beverageName}:");
            Console.WriteLine($"{(energy*ratio)}kcal, {(sugar*ratio)}g sugars");
        }
    }
}
