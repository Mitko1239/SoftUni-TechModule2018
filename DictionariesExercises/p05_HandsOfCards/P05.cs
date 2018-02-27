using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_HandsOfCards
{
    class P05
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List<string>> values = new Dictionary<string, List<string>>();

            while (data[0] != "JOKER")
            {
                string name = data[0];
                List<string> cards = data[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!values.ContainsKey(name))
                {
                    values.Add(name, cards);
                }
                else
                {
                    values[name].AddRange(cards);
                }

                data = Console.ReadLine()
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }



            foreach (var players in values)
            {
                List<string> uniqueCards = players.Value;
                uniqueCards = uniqueCards.Distinct().ToList();
                int result = 0;

                List<int> results = new List<int>();

                foreach (var item in uniqueCards)
                {
                    string power = item.Substring(0, item.Length - 1).ToString();
                    string type = item.Last().ToString();

                    switch (power)
                    {
                        case "J":
                            power = "11";
                            break;

                        case "Q":
                            power = "12";
                            break;

                        case "K":
                            power = "13";
                            break;

                        case "A":
                            power = "14";
                            break;

                        default:
                            break;
                    }

                    switch (type)
                    {
                        case "S":
                            type = "4";
                            break;

                        case "H":
                            type = "3";
                            break;

                        case "D":
                            type = "2";
                            break;

                        case "C":
                            type = "1";
                            break;

                        default:
                            break;
                    }

                    result += int.Parse(power) * int.Parse(type);
                }

                results.Add(result);
                results = results.Distinct().ToList();

                Console.WriteLine($"{players.Key}: {string.Join(" ", results)}");
            }
        }
    }
}
