using System;
using System.Collections.Generic;

namespace Objects_and_Classes___Exercise
{
    class Program
    {
        private static object rnd;

        static void Main(string[] args)
        {
            int messanges = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string>()
            { "Excellent product."
                , "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            List<string> events = new List<string>()
            { "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!" };
            List<string> authors = new List<string>()
            {"Diana", "Petya", "Stella", "Elena", "Katya",
                "Iva", "Annie", "Eva"};
            List<string> cities = new List<string>()
            {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            Random rnd = new Random();
            for (int i = 0; i < messanges; i++)
            {
                int randomPhrases = rnd.Next(0, phrases.Count - 1);
                int randomEvents = rnd.Next(0, events.Count - 1);
                int randomCities = rnd.Next(0, cities.Count - 1);
                int randomAuthor = rnd.Next(0, authors.Count - 1);
                Console.WriteLine($"{phrases[randomPhrases]} {events[randomEvents]} {authors[randomAuthor]} - {cities[randomCities]}.");
            }
        }
    }
}

