using System;

namespace p07_CakeIngredients
{
    class P07
    {
        static void Main(string[] args)
        {
            //string ingredient;
            //int counter = 0;
            //do
            //{
            //    ingredient = Console.ReadLine();
            //    if (ingredient != "Bake!")
            //    {
            //        Console.WriteLine($"Adding ingredient {ingredient}.");
            //        counter++;
            //    }
            //} while (ingredient != "Bake!");

            //Console.WriteLine($"Preparing cake with {counter} ingredients.");

            //Variant 2
            string ingredient = Console.ReadLine();
            int counter = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
