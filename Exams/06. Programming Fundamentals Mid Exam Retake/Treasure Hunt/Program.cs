using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();
            string[] command = Console.ReadLine().Split(" ").ToArray();
            List<string> stolenItems = new List<string>();
            double sum = 0;
            while (command[0] != "Yohoho!")
            {
                if (command[0] == "Loot")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        if (!chest.Contains(command[i]))
                        {
                            chest.Insert(0, command[i]);
                        }
                    }
                }
                else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);
                    string currentLoot = "";
                    if (index >= 0 && index < chest.Count)
                    {
                        currentLoot = chest[index];
                        chest.RemoveAt(index);
                        chest.Add(currentLoot);
                    }
                }
                else if (command[0] == "Steal")
                {
                    int count = int.Parse(command[1]);
                    if (count > chest.Count)
                    {
                        count = chest.Count;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        stolenItems.Insert(0, chest[chest.Count - 1]);  
                        chest.RemoveAt(chest.Count - 1);
                    }
                    Console.WriteLine(string.Join(", ",stolenItems));
                    stolenItems.Clear();
                }
                command = Console.ReadLine().Split().ToArray();
            }
            foreach (var item in chest)
            {
                sum += item.Length;
            }
            if (chest.Count == 0)
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
            else
            {
            Console.WriteLine($"Average treasure gain: {sum / chest.Count:F2} pirate credits.");
            }
        }
    }
}