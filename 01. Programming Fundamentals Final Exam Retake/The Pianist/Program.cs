using System;
using System.Linq;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> pianists = new Dictionary<string, Dictionary<string, string>>();
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] currentPianist = Console.ReadLine().Split("|");
                pianists.Add(currentPianist[0], new Dictionary<string, string> { { currentPianist[1], currentPianist[2] } });
            }
            string[] commands = Console.ReadLine().Split("|");
            while (commands[0]!="Stop")
            {
                if (commands[0] == "Add")
                {
                    if (!pianists.ContainsKey(commands[1]))
                    {
                        pianists.Add(commands[1], new Dictionary<string, string> { { commands[2], commands[3] } });
                        Console.WriteLine($"{commands[1]} by {commands[2]} in {commands[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{commands[1]} is already in the collection!");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (pianists.ContainsKey(commands[1]))
                    {
                        pianists.Remove(commands[1]);
                        Console.WriteLine($"Successfully removed {commands[1]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
                    }
                }
                else if (commands[0] == "ChangeKey")
                {
                    if (pianists.ContainsKey(commands[1]))
                    {
                        string name = "";
                        string comp = "";
                        string key = "";
                        foreach (var item in pianists)
                        {
                            if (item.Key == commands[1])
                            {
                                name = item.Key;
                                foreach (var piece in item.Value)
                                {
                                    comp = piece.Key;
                                    key = piece.Value;
                                }
                            }
                        }
                        key = commands[2];
                        pianists.Remove(commands[1]);
                        pianists.Add(name, new Dictionary<string,string> { {comp, key } });
                        Console.WriteLine($"Changed the key of {name} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {commands[1]} does not exist in the collection.");
                    }
                }
                commands = Console.ReadLine().Split("|");
            }
            var sortedPianists = pianists.OrderBy(s => s.Key).ThenBy(s => s.Value).ToDictionary(s => s.Key, s => s.Value);
            foreach (var item in sortedPianists)
            {
                Console.WriteLine($"{item.Key} -> {string.Join("",item.Value.Select(s=>$"Composer: {s.Key}, Key: {s.Value}"))}");
                
            }
        }
    }
}
