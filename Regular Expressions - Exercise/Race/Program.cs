using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            string information = Console.ReadLine();
            string regexName = @"[A-Z a-z]+";
            string regexDigits = @"[0-9]";
            Dictionary<string, int> persons = new Dictionary<string, int>();
            while (information != "end of race")
            {
                MatchCollection matchName = Regex.Matches(information, regexName);
                if (matchName.Count > 0)
                {
                    string currentName = "";
                    foreach (Match item in matchName)
                    {
                        currentName += item.Value;
                    }
                    for (int i = 0; i < names.Length; i++)
                    {
                        bool isFind = false;
                        string name = names[i]; 
                        if (name == currentName)
                        {
                            isFind = true;
                            MatchCollection matchDigit = Regex.Matches(information, regexDigits);
                            if (matchDigit.Count > 0)
                            {
                                int sum = 0;
                                foreach (Match d in matchDigit)
                                {
                                    int digit = int.Parse(d.Value);
                                    sum += digit;
                                }
                                if (persons.ContainsKey(name))
                                {
                                    persons[name] += sum;
                                }
                                else
                                {
                                    persons.Add(name, sum);
                                }
                            }
                        }
                        if (isFind)
                        {
                            break;
                        }
                    }
                }
                information = Console.ReadLine();
            }
            List<string> bestNames = new List<string>();
            foreach (var item in persons.OrderByDescending(s => s.Value).Take(3))
            {
                bestNames.Add(item.Key);
            }
            Console.WriteLine($"1st place: {bestNames[0]}");
            Console.WriteLine($"2nd place: {bestNames[1]}");
            Console.WriteLine($"3rd place: {bestNames[2]}");  
        }
    }
}
