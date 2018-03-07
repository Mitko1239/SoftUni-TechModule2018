using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<int, Event> eventsBook = new Dictionary<int, Event>();

            while (!inputLine.Equals("Time for Code"))
            {
                string[] inputElements = inputLine
                    .Split(new char[] {' ', '\t', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

                if (!inputElements[1].Contains('#'))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                int eventId = int.Parse(inputElements[0]);
                char[] eventName = inputElements[1].Skip(1).ToArray();
                string name = string.Join("", eventName);

                if (eventsBook.ContainsKey(eventId) && !eventsBook[eventId].Name.Equals(name))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                else if (eventsBook.ContainsKey(eventId) && eventsBook[eventId].Name.Equals(name))
                {
                    for (int i = 2; i < inputElements.Length; i++)
                    {
                        if (eventsBook[eventId].Participant.Contains(inputElements[i]))
                        {
                            continue;
                        }
                        else
                        {
                            eventsBook[eventId].Participant.Add(inputElements[i]);
                        }
                    }
                }

                else
                {
                    Event currentEvent = new Event();
                    currentEvent.Name = name;

                    for (int i = 2; i < inputElements.Length; i++)
                    {
                        if (!inputElements[i].Contains('@'))
                        {
                            continue;
                        }

                        if (!currentEvent.Participant.Contains(inputElements[i]))
                        {
                            currentEvent.Participant.Add(inputElements[i]);
                        }
                    }

                    eventsBook[eventId] = currentEvent;
                }

                inputLine = Console.ReadLine();
            }

            eventsBook = eventsBook
                .OrderByDescending(v => v.Value.Participant.Count())
                .ThenBy(v => v.Value.Name)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var evenT in eventsBook)
            {
                Console.WriteLine($"{evenT.Value.Name} - {evenT.Value.Participant.Count()}");
                foreach (var item in evenT.Value.Participant.OrderBy(x => x))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    class Event
    {
        public Event()
        {
            this.Participant = new List<string>();
        }

        public List<string> Participant { get; set; }
        public string Name { get; set; }
    }
}