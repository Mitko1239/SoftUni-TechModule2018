using System;

namespace p03_RestaurantDiscount
{
    class P03
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int priceHall = 0;
            int pricePackage = 0;
            double discount = 0;
            string hallName = "";

            switch(package.ToLower())
            {
                case "normal":
                    discount = 0.05;
                    pricePackage = 500;
                    break;
                case "gold":
                    discount = 0.1;
                    pricePackage = 750;
                    break;
                case "platinum":
                    discount = 0.15;
                    pricePackage = 1000;
                    break;
            }

            if (groupSize > 0 && groupSize <= 50)
            {
                hallName = "Small Hall";
                priceHall = 2500;
            } else if(groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                priceHall = 5000;
            } else if(groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                priceHall = 7500;
            }

            double totalPrice = (priceHall + pricePackage) - discount * (priceHall + pricePackage);
            double pricePerPerson = totalPrice / groupSize;

            if (groupSize < 0 || groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            } else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
