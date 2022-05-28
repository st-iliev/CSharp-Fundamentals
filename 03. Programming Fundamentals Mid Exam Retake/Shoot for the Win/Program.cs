using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            if (command == "End")
            {
                Console.Write($"Shot targets: 0 -> ");
                Console.WriteLine(string.Join(" ", targets));
                return;
            }
            int shot = int.Parse(command);
            int shotsCount = 0;
            while (true)
            {
                if (shot >= 0 && shot < targets.Count)
                {
                    if (targets[shot] > -1)
                    {
                        int currentValue = targets[shot];
                        targets[shot] = -1;
                        shotsCount++;
                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i] > currentValue)
                            {
                                targets[i] -= currentValue;
                            }
                            else if (targets[i] <= currentValue)
                            {
                                if (targets[i] != -1)
                                {
                                    targets[i] += currentValue;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                shot = int.Parse(command);
            }
            Console.Write($"Shot targets: {shotsCount} -> ");
            Console.WriteLine(string.Join(" ",targets));



        }
    }
}
