using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace StringsDemo
{
    class StringsDemo
    {
        static string ReverseString(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {

            //country town street number family
            // key -> key -> key -> key -> value
            // Bulgaria -> Sofia -> Tintyava -> 15 -> Peshovi
            // Bulgaria -> Plovdiv -> Bulgaria -> 12 -> Peshovi
            Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<int, List<string>>>>> map = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<int, List<string>>>>>();
            Dictionary<string, int> max = new Dictionary<string, int>();

            for (int i = 0; i < 2; i++)
            {

                string[] tokens = Console.ReadLine().Split(" -> ");

                string country = tokens[0].Trim();
                string town = tokens[1];
                string street = tokens[2];
                int number = int.Parse(tokens[3]);
                string family = tokens[4];


                if (!map.ContainsKey(country))
                {
                    map.Add(country, new Dictionary<string, Dictionary<string, Dictionary<int, List<string>>>>());
                    max.Add(country, 0);
                }

                if (!map[country].ContainsKey(town))
                {
                    map[country].Add(town, new Dictionary<string, Dictionary<int, List<string>>>());
                }

                if (!map[country][town].ContainsKey(street))
                {
                    map[country][town].Add(street, new Dictionary<int, List<string>>());
                }

                if (!map[country][town][street].ContainsKey(number))
                {
                    if (max[country] < number)
                    {
                        max[country] = number;
                    }
                    map[country][town][street].Add(number, new List<string>());
                }

                map[country][town][street][number].Add(family);
                //map[country][town][street][number] = map[country][town][street][number].Distinct().ToList();
            }

            var sorted = max.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var country in sorted)
            {
                Console.WriteLine($"Country: {country.Key}");
                var sortedTown = map[country.Key].OrderBy(a => a.Key);
                foreach (var town in sortedTown)
                {
                    Console.WriteLine($"   Town: {town.Key}");

                    foreach (var st in town.Value.OrderByDescending(x => x.Value.OrderBy(n => n.Value.OrderBy(a => a))))
                    {
                        Console.Write($"      Street: {st.Key}");
                        foreach (var number in st.Value)
                        {
                            Console.WriteLine($" {number.Key}:");
                            foreach (var family in st.Value)
                            {
                                Console.WriteLine($"         sem. {string.Join(Environment.NewLine, family.Value)}");
                            }
                        }
                    }
                }
            }







            //var timer = new Stopwatch();
            //timer.Start();
            //var result = new StringBuilder();
            //for (int i = 0; i < 50000; i++)
            //    result.Append(Convert.ToString(i, 2));
            //Console.WriteLine(result.Length);
            //Console.WriteLine(timer.Elapsed);
            //Console.Write("Pesho"[5]);



            //string input = Console.ReadLine();
            //Console.WriteLine(ReverseString(input));

            //string s = " \t\nHel?lo!!! \n";
            //string clean = s.Replace("?", "");

            //Console.WriteLine(clean);


            //string[] badWords = Console.ReadLine().Split(',');
            //string text = Console.ReadLine();

            //foreach (var badWord in badWords)
            //{
            //    text = text.Replace(badWord.Trim(), new string('*', badWord.Trim().Length));
            //}
            //Console.WriteLine(text);






            //string text = Console.ReadLine().ToLower();
            //string substr = Console.ReadLine().ToLower();
            //int counter = 0;
            //int index = -1;

            //while (true)
            //{
            //    index = text.IndexOf(substr, index+1);

            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        counter++;
            //    }

            //}

            //Console.WriteLine(counter);








            //string name = "Пешо";
            //string name2 = "ПЕШО";
            //string name3 = "Пешо";

            //string email = "vasko@gmail.org";
            //var index = email.LastIndexOf("@");

            //Console.WriteLine(index);
            //string greeting = "السَّلَامُ عَلَيْكُمْ";
        }
    }
}
