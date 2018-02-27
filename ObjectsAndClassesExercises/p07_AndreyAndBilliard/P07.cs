using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_AndreyAndBilliard
{
    class P07
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            int numEntities = int.Parse(Console.ReadLine());
            string name;
            decimal price;

            for (int i = 0; i < numEntities; i++)
            {
                string[] entity = Console.ReadLine().Split('-');
                name = entity[0];
                price = decimal.Parse(entity[1]);

                if (!shop.ContainsKey(name))
                {
                    shop.Add(name, price);
                }
                else
                {
                    shop[name] = price;
                }
            }

            //Dictionary<string, Dictionary<string, int>> customers = new Dictionary<string, Dictionary<string, int>>();

            List<Customer> customers = new List<Customer>();
            string[] order = Console.ReadLine().Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

            while (order[0] != "end of clients")
            {

                string customerName = order[0];
                string product = order[1];
                int quantity = int.Parse(order[2]);

                if (shop.ContainsKey(product))
                {
                    decimal bill = quantity * shop[product];

                    Customer currentCustomer = new Customer();
                    currentCustomer.Name = customerName;
                    currentCustomer.ShopList = new Dictionary<string, int>();
                    currentCustomer.ShopList.Add(product, quantity);
                    currentCustomer.Bill = bill;

                    if (customers.Any(x => x.Name == currentCustomer.Name))
                    {
                        Customer existingCustomer = customers.First(x => x.Name == currentCustomer.Name);

                        if (!existingCustomer.ShopList.ContainsKey(product))
                        {
                            existingCustomer.ShopList[product] = quantity;
                        }
                        else
                        {
                            existingCustomer.ShopList[product] += quantity;
                        }
                        existingCustomer.Bill += bill;
                    }
                    else
                    {
                        customers.Add(currentCustomer);
                    }
                }


                order = Console.ReadLine().Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            decimal totalBill = 0;
            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var entry in customer.ShopList)
                {
                    Console.WriteLine($"-- {entry.Key} - {entry.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
