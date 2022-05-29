using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            List<string> commands = Console.ReadLine().Split(" - ").ToList();
            List<string> combineItems = new List<string>();
            while (commands[0] != "Craft!")
            {
                if (commands[0] == "Collect")
                {
                    bool isFind = false;
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (commands[1] == items[i])
                        {
                            isFind = true;
                            break;
                        }
                    }
                    if (!isFind)
                    {
                        items.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Drop")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (commands[1] == items[i])
                        {
                            items.Remove(commands[1]);
                            break;
                        }
                    }
                }
                else if (commands[0] == "Combine Items")
                {
                    combineItems = commands[1].Split(":").ToList();
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (combineItems[0] == items[i])
                        {
                            if (i == items.Count - 1)
                            {
                                items.Add(combineItems[1]);
                            }
                            else if (i < items.Count - 1)
                            {
                                items.Insert(i + 1, combineItems[1]);
                            }
                            break;
                        }
                    }

                }
                else if (commands[0] == "Renew")
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (commands[1] == items[i])
                        {
                            if (i == items.Count - 1)
                            {
                                break;
                            }
                            else if (i < items.Count - 1)
                            {
                                string currentItem = items[i];
                                items.Remove(items[i]);
                                items.Add(currentItem);
                            }
                            break;
                        }
                    }
                }
                commands = Console.ReadLine().Split(" - ").ToList();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
