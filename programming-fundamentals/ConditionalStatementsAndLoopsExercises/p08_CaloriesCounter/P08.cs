using System;

namespace p08_CaloriesCounter
{
    class P08
    {
        static void Main(string[] args)
        {
            int ingredientsNum = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < ingredientsNum; i++)
            {
                string ingredient = Console.ReadLine();
                if(ingredient.ToLower() == "cheese")
                {
                    calories += 500;
                } else if (ingredient.ToLower() == "tomato sauce")
                {
                    calories += 150;
                } else if (ingredient.ToLower() == "salami")
                {
                    calories += 600;
                } else if (ingredient.ToLower() == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");

            //Variant 2?
        }
    }
}
