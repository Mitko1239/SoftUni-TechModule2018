using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p10_SrabskoUnleashed
{
    class P10
    {
        static void Main(string[] args)
        {
            string venues;
            string singerName;
            int ticketPrice;
            long ticketCount;
            long totalMoney;

            var placeAndSingers = new Dictionary<string, Dictionary<string, long>>();
            const string pattern = @"([A-Za-z\s]+)\s(@[A-Za-z\s]+)\s(\d+)\s(\d+)";


            string concertInfo = Console.ReadLine();

            while (concertInfo.Equals("End") == false)
            {
                var isTheInputValid = Regex.Match(concertInfo, pattern);

                if (isTheInputValid.Success)
                {

                    singerName = isTheInputValid.Groups[1].ToString().TrimEnd();
                    venues = isTheInputValid.Groups[2].ToString().TrimEnd();
                    venues = venues.Substring(1);
                    ticketPrice = int.Parse(isTheInputValid.Groups[3].ToString());
                    ticketCount = int.Parse(isTheInputValid.Groups[4].ToString());
                    totalMoney = ticketCount * ticketPrice;


                    if (placeAndSingers.ContainsKey(venues) == false)
                    {
                        placeAndSingers.Add(venues, new Dictionary<string, long>());
                        placeAndSingers[venues].Add(singerName, totalMoney);
                    }
                    else
                    {
                        if (placeAndSingers[venues].ContainsKey(singerName) == false)
                        {
                            placeAndSingers[venues].Add(singerName, totalMoney);
                        }
                        else
                        {
                            placeAndSingers[venues][singerName] += totalMoney;
                        }
                    }
                }

                concertInfo = Console.ReadLine();
            }

            foreach (var place in placeAndSingers)
            {
                Console.WriteLine($"{place.Key}");

                foreach (var singerAndMoney in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singerAndMoney.Key} -> {singerAndMoney.Value}");
                }
            }
        }

        static void Main2(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Dictionary<string, long>> singersByCity = new Dictionary<string, Dictionary<string, long>>();
            string singerName = "";
            string cityName = "";
            int ticketPrice = 0;
            int ticketsAmount = 0;
            int totalPrice = 0;

            while (input[0] != "End")
            {
                singerName = input[0].TrimEnd();
                var helper = input[1].Split(' ').ToList();

                List<string> city = helper.Take(helper.Count - 2).ToList();
                cityName = string.Join(" ", city);

                helper.RemoveRange(0, helper.Count - 2);

                bool ticketPriceParse = int.TryParse(helper[0], out ticketPrice);
                bool ticketsAmountParse = int.TryParse(helper[1], out ticketsAmount);
                if (!ticketsAmountParse || !ticketPriceParse)
                {
                    input = Console.ReadLine().Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                else
                {
                    totalPrice = ticketPrice * ticketsAmount;

                    if (!singersByCity.ContainsKey(cityName))
                    {
                        Dictionary<string, long> singerAndPrice = new Dictionary<string, long>();
                        singerAndPrice.Add(singerName, totalPrice);
                        singersByCity.Add(cityName, singerAndPrice);
                    }
                    else
                    {
                        if (!singersByCity[cityName].ContainsKey(singerName))
                        {
                            singersByCity[cityName].Add(singerName, totalPrice);
                        }
                        else
                        {
                            singersByCity[cityName][singerName] += totalPrice;
                        }
                    }

                    input = Console.ReadLine().Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
            }

            foreach (var city in singersByCity)
            {
                Console.WriteLine($"{city.Key}");
                foreach (var singer in city.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
