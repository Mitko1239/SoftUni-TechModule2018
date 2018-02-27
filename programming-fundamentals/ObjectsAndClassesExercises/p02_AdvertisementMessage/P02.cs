using System;

namespace p02_AdvertisementMessage
{
    class P02
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] towns = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int numMessages = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < numMessages; i++)
            {
                int phraseIndex = rnd.Next(0, phrases.Length);
                int eventIndex = rnd.Next(0, events.Length);
                int authorIndex = rnd.Next(0, authors.Length);
                int townIndex = rnd.Next(0, towns.Length);
                var advertisement = new { Phrase = phrases[phraseIndex], Event = events[eventIndex], Author = authors[authorIndex], Town = towns[townIndex] };
                Console.WriteLine($"{advertisement.Phrase} {advertisement.Event} {advertisement.Author} - {advertisement.Town}");
            }
        }
    }
}
