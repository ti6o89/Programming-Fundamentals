using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int pharaseIndex = rnd.Next(0, phrases.Length - 1);
                int eventIndex = rnd.Next(0, events.Length - 1);
                int authorIndex = rnd.Next(0, author.Length - 1);
                int townIndex = rnd.Next(0, cities.Length - 1);

                Console.WriteLine($"{phrases[pharaseIndex]} {events[eventIndex]} {author[authorIndex]} - {cities[townIndex]}.");
            }

        }
    }
}
