using System;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"([\:\:]{2}|[**]{2})(?<emoji>[A-Z][a-z]{2,})(\1)";
            string coolThreshold = @"(?<threshold>[0-9]+)";
            MatchCollection machesEmoji = Regex.Matches(input, regex);
            MatchCollection machesThreshold = Regex.Matches(input, coolThreshold);
            int sum = 1;
            foreach (Match item in machesThreshold)
            {
                if (item.Groups["threshold"].Value.Length > 1)
                {
                    foreach (var digit in item.Groups["threshold"].Value)
                    {
                        sum *= int.Parse(digit.ToString());
                    }
                }
                else
                {
                sum *= int.Parse(item.Groups["threshold"].Value);
                }
            }
            Console.WriteLine($"Cool threshold: {sum}");
            Console.WriteLine($"{machesEmoji.Count} emojis found in the text. The cool ones are:");
            foreach (Match emoji in machesEmoji)
            {
                string emojiName = emoji.Groups["emoji"].Value;
                int emojiCools = 0;
                foreach (var item in emojiName)
                {
                    emojiCools += char.Parse(item.ToString());
                }
                if (emojiCools > sum)
                {
                    Console.WriteLine($"{emoji.Value}");
                }
            }
        }
    }
}
