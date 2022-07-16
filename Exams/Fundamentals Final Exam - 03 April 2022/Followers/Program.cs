using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> followerLike = new Dictionary<string, int>();
            Dictionary<string, int> followerComment = new Dictionary<string, int>();
            string[] commands = Console.ReadLine().Split(": ");
            while (commands[0]!="Log out")
            {
                if (commands[0] == "New follower")
                {
                    if (!followerLike.ContainsKey(commands[1]))
                    {
                        followerLike.Add(commands[1], 0);
                        followerComment.Add(commands[1], 0);
                    }
                }
                else if (commands[0] == "Like")
                {
                    if (!followerLike.ContainsKey(commands[1]))
                    {
                        followerLike.Add(commands[1], int.Parse(commands[2]));
                        followerComment.Add(commands[1], 0);
                    }
                    else
                    {
                        followerLike[commands[1]] += int.Parse(commands[2]);
                    }
                }
                else if (commands[0] == "Comment")
                {
                    if (!followerComment.ContainsKey(commands[1]))
                    {
                        followerComment.Add(commands[1], 1);
                        followerLike.Add(commands[1], 0);
                    }
                    else
                    {
                        followerComment[commands[1]] += 1;
                    }
                }
                else if (commands[0] == "Blocked")
                {
                    if (followerLike.ContainsKey(commands[1]))
                    {
                        followerLike.Remove(commands[1]);
                        followerComment.Remove(commands[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[1]} doesn't exist.");
                    }
                }
                    commands = Console.ReadLine().Split(": ");
            }
            Console.WriteLine($"{followerLike.Count} followers");
            if (followerLike.Count > 0)
            {
                foreach (var like in followerLike)
                {
                    foreach (var comm in followerComment)
                    {
                        if (like.Key == comm.Key)
                        {
                            Console.WriteLine($"{like.Key}: {like.Value + comm.Value}");
                        }
                    }
                }
            }
        }
    }
}
