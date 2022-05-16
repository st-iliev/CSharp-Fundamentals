using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { 's', 't', 'a', 'r' };
            string regex = @"@(?<planetname>[A-z]+)+([^@\-!:>]*):(?<population>[0-9]+)!([^@\-!:>]*)(?<attacktype>[A,D])!([^@\-!:>]*)->(?<soldiercount>[0-9]+)";
            int lines = int.Parse(Console.ReadLine());
            List<string> attackType = new List<string>();
           List<string> destroyType = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();
                string decryptMessage = "";
                int sum = message.ToLower().Count(s => s == 's' || s == 't' || s == 'a' || s == 'r');

                foreach (char item in message)
                {
                    decryptMessage += (char)(item - sum);
                }
                MatchCollection decrypt = Regex.Matches(decryptMessage, regex);
                foreach (Match item in decrypt)
                {
                    string name = item.Groups["planetname"].Value;
                    if (item.Groups["attacktype"].Value == "A")
                    {
                        
                        attackType.Add(name);
                    }
                    else
                    {
                        destroyType.Add(name);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attackType.Count}");
            if (attackType.Count > 0)
            {
                attackType.Sort();
                foreach (var item in attackType)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyType.Count}");
            if (destroyType.Count > 0)
            {
                destroyType.Sort();
                foreach (var item in destroyType)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}

