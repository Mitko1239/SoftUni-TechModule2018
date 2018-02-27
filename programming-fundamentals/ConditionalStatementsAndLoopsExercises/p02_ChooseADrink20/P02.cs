using System;

namespace p02_ChooseADrink20
{
    class P02
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink;
            double price;

            switch (profession.ToLower())
            {
                case "athlete":
                    drink = "Water";
                    break;
                case "businessman":
                case "businesswoman":
                    drink = "Coffee";
                    break;
                case "softuni student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }

            switch (drink)
            {
                case "Water":
                    price = 0.7;
                    break;
                case "Coffee":
                    price = 1.0;
                    break;
                case "Beer":
                    price = 1.7;
                    break;
                case "Tea":
                default:
                    price = 1.2;
                    break;
            }

            double totalPrice = price * quantity;

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
