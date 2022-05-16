using System;
using System.Text.RegularExpressions;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string textLine = Console.ReadLine();
            string regex = @"(^|\s)(?<email>[A-Za-z0-9][\w\-.]*[A-za-z0-9]+@[A-za-z0-9]+([-.][A-Za-z0-9]+)+)\b";
            MatchCollection validEmails = Regex.Matches(textLine, regex);
            foreach (Match item in validEmails)
            {
                Console.WriteLine($"{item.Groups["email"].Value}");
            }
        }
    }
}
