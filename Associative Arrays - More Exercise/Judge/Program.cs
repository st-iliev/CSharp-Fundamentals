using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> judgeSystem = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> usernamePoints = new Dictionary<string, int>();
            string[] contests = Console.ReadLine().Split(" -> ");
            while (contests[0] != "no more time")
            {
                string username = contests[0];
                string contest = contests[1];
                int points = int.Parse(contests[2]);

                if (!judgeSystem.ContainsKey(contest))
                {
                    judgeSystem.Add(contest, new Dictionary<string, int> { { username, points } });
                    if (usernamePoints.ContainsKey(username))
                    {
                        usernamePoints[username] += points;
                    }
                }
                else if (judgeSystem.ContainsKey(contest))
                {
                    if (judgeSystem[contest].ContainsKey(username))
                    {
                        if (judgeSystem[contest][username] < points)
                        {
                            judgeSystem[contest][username] = points;
                            usernamePoints[username] = points;

                        }
                    }
                    else
                    {
                        judgeSystem[contest].Add(username, points);
                        if (!usernamePoints.ContainsKey(username))
                        {
                            usernamePoints.Add(username, points);
                        }
                        else
                        {
                            usernamePoints[username] += points;
                        }
                    }
                }
                if (!usernamePoints.ContainsKey(username))
                {
                    usernamePoints.Add(username, points);
                }

                contests = Console.ReadLine().Split(" -> ");
            }

            int count = 1;

            foreach (var item in judgeSystem)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()} participants");
                Console.WriteLine($"{string.Join("\n", item.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key).Select(s => $"{count++}. {s.Key} <::> {s.Value}"))}");
                count = 1;
            }
            Console.WriteLine($"Individual standings:");
            usernamePoints = usernamePoints.OrderByDescending(s => s.Value).ThenBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
            count = 1;
            foreach (var item in usernamePoints)
            {
                Console.WriteLine($"{count++}. {item.Key} -> {item.Value}");
            }
        }
    }
}

