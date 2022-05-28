using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string locationPattern = @"([=]|[\/])(?<location>([A-Z]){1}([A-Za-z]){2,})(\1)";
            MatchCollection locations = Regex.Matches(input, locationPattern);
            List<string> foundLocations = new List<string>();
            int locationLenght = 0;
            foreach (Match item in locations)
            {
                foundLocations.Add(item.Groups["location"].Value);
                locationLenght += item.Groups["location"].Value.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", foundLocations)}");
            Console.WriteLine($"Travel Points: {locationLenght}");
        }
    }
}
