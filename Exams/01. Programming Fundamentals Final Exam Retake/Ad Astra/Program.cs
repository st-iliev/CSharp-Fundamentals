using System;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentText = Console.ReadLine();
            string regex = @"([|]|[#])(?<food>[A-Za-z ]+)(\1)(?<date>[0-9]{2}[\/][0-9]{2}[\/][0-9]{2})(\1)(?<calories>[0-9]+)(\1)";
            MatchCollection matches = Regex.Matches(currentText, regex);
            int totalCalories = 0;
            foreach (Match item in matches)
            {
                totalCalories += int.Parse(item.Groups["calories"].Value.ToString());
            }
            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");
            foreach (Match item in matches)
            {
                string name = item.Groups["food"].Value;
                string date = item.Groups["date"].Value;
                int calories = int.Parse(item.Groups["calories"].Value.ToString());
                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
