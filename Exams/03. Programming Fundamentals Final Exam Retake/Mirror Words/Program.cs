using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"([@]|[#])(?<firstword>[a-zA-Z]{3,})(\1){2}(?<secondword>[a-zA-Z]{3,})(\1)";
            MatchCollection maches = Regex.Matches(input, regex);
            List<string> result = new List<string>();
            if (maches.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
            Console.WriteLine($"{maches.Count} word pairs found!");
            }
            int count = 0;
            foreach (Match item in maches)
            {
                string firstWord = item.Groups["firstword"].Value;
                string secondWord = item.Groups["secondword"].Value;
                string reversedWord = "";
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedWord += secondWord[i];
                }
                string concat = "";
                if (firstWord == reversedWord)
                {
                    concat = firstWord;
                    concat += " <=> ";
                    concat += secondWord;
                    result.Add(concat);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine($"{string.Join(", ",result)}");
            }
        }
    }
}
