using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsNames = Console.ReadLine().Split(", ").ToList();
            string[] commands = Console.ReadLine().Split();
            int blackList = 0;
            int lostList = 0;
            while (commands[0] != "Report")
            {
                if (commands[0] == "Blacklist")
                {
                    if (friendsNames.Contains(commands[1]))
                    {
                        int index = friendsNames.IndexOf(commands[1]);
                        blackList++;
                        Console.WriteLine($"{commands[1]} was blacklisted.");
                        friendsNames[index] = "Blacklisted";
                    }
                    else
                    {
                        Console.WriteLine($"{commands[1]} was not found.");
                    }
                }
                else if (commands[0] == "Error")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < friendsNames.Count)
                    {
                        if (friendsNames[index] != "Blacklisted" && friendsNames[index] != "Lost")
                        {
                            Console.WriteLine($"{friendsNames[index]} was lost due to an error.");
                            lostList++;
                            friendsNames[index] = "Lost";
                        }
                    }
                }
                else if (commands[0] == "Change")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < friendsNames.Count)
                    {
                        Console.WriteLine($"{friendsNames[index]} changed his username to {commands[2]}.");
                        friendsNames[index] = commands[2];
                    }
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine($"Blacklisted names: {blackList}");
            Console.WriteLine($"Lost names: {lostList}");       
            Console.WriteLine(string.Join(" ",friendsNames));
        }
    }
}
