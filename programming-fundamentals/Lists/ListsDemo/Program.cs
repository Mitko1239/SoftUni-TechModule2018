using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToList();

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }


            //List<string> names = new List<string>()
            //{
            //    "Pesho",
            //    "Gosho",
            //    "Momiche",
            //};

            //List<int> numbers = new List<int>()
            //{
            //    100,
            //    200,
            //    300,
            //};

            //names.Add("Mimi");
            //names.Add("Mimi");
            //names.RemoveAll(n => n == "Mimi");
            //names.RemoveAt(2);


            //numbers.Add(400);
            //numbers.Add(500);
            //Console.WriteLine(string.Join(", ", numbers));
            ////numbers.Insert(3, 350);

            //int[] numbersArr = { 20, 30, 40, 50 };
            //numbers.AddRange(numbersArr);

            //numbers.Sort();
            //numbers.Reverse();

            //Console.WriteLine(string.Join(", ", numbers));



            //names.TrimExcess();

            //names.Add("Mimi");

            //Console.WriteLine(string.Join(", ", names));
            //names.Add("Peter");
            //names.Add("Maria");
            //names.Add("George");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name); names.Remove("Maria");
            //}
            //Console.WriteLine(String.Join(", ", names));

        }
    }
}
