using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercise_Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string[] contestInfo = Console.ReadLine().Split(":");
            while (contestInfo[0] != "end of contests")
            {
                string contest = contestInfo[0];
                string contestPassword = contestInfo[1];
                contests.Add(contest, contestPassword);
                contestInfo = Console.ReadLine().Split(":");
            }

            SortedDictionary<string, Dictionary<string, int>> submissions = new SortedDictionary<string, Dictionary<string, int>>();
            string[] submissionInfo = Console.ReadLine().Split("=>");
            while (submissionInfo[0] != "end of submissions")
            {
                string contest = submissionInfo[0];
                string contestPassword = submissionInfo[1];
                string username = submissionInfo[2];
                int points = int.Parse(submissionInfo[3]);
                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == contestPassword)
                    {
                        if (!submissions.ContainsKey(username))
                        {
                            submissions.Add(username, new Dictionary<string, int> { { contest, points } });
                        }
                        else if (submissions[username].ContainsKey(contest))
                        {
                            if (submissions[username][contest] < points)
                            {
                                submissions[username][contest] = points;
                            }
                        }
                        else
                        {
                            submissions[username].Add(contest, points);
                        }
                    }
                }
                submissionInfo = Console.ReadLine().Split("=>");
            }
            Dictionary<string, int> usernamePoints = new Dictionary<string, int>();
            foreach (var item in submissions)
            {
                usernamePoints[item.Key] = item.Value.Values.Sum();
            }
            string bestUsername = usernamePoints.Keys.Max();
            int mostPoints = usernamePoints.Values.Max();
            foreach (var item in usernamePoints)
            {
                if (item.Value == mostPoints)
                {
                    Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");

                }
            }
            //Console.WriteLine($"Best candidate is {bestUsername} with total {mostPoints} points.");
            Console.WriteLine($"Ranking:");
            foreach (var items in submissions)
            {
                Console.WriteLine($"{items.Key}");
                Console.WriteLine($"# {string.Join("\n# ", items.Value.OrderByDescending(s => s.Value).Select(s => $" { s.Key} -> {s.Value}"))} ");
            }
        }
    }
}
