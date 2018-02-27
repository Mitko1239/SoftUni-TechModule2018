using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 2 3 4 5 6 7.5 7.5 8 8 9
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            foreach (var num in numbers)
            {
                if (count.ContainsKey(num) == false)
                {
                    count[num] = 0;
                }
                count[num]++;
            }

            foreach (var pair in count.OrderByDescending(num => num.Key).Where(x => x.Value > 1))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }


            //double [] numbers = Console.ReadLine()
            //    .Split()
            //    .Select(double.Parse)
            //    .ToArray();

            //Dictionary<string, string> students = new Dictionary<string, string>();

            //students["Pesho"] = "100";
            //students["Gosho"] = "300";
            //students["Mimi"] = "200";

            //foreach (var st in students.OrderByDescending(x=>x.Key))
            //{
            //    Console.WriteLine($"{st}");
            //}

            //var nums = new List<int>() { 10, 20, 30, 40, 50, 60 }
            //  .Skip(3).Take(2)
            //  .ToArray();

            //Console.WriteLine(string.Join(" ",nums));



            //var dict = numbers.ToDictionary(x => x, y => y = 0);


            //var students = new SortedDictionary<string, double>();

            //students.Add("Pesho", 5.49);
            //students.Add("Gosho", 6.00);
            //students.Add("Mimi", 5.00);
            //students.Add("Ivan", 2.00);

            //if (students.ContainsKey("Pesho"))
            //{
            //    students["Pesho"] = 6.00;
            //}


            //students["Pesho"] = 5.51;

            //foreach (var st in students)
            //{
            //    Console.WriteLine("{0} -> {1}", st.Key, st.Value);
            //}

            //Console.WriteLine(students["Pesho"]);
        }
    }
}
