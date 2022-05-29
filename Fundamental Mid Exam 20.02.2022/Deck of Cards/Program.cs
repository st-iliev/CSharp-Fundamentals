using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cardsNames = Console.ReadLine().Split(", ").ToList();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] commands = Console.ReadLine().Split(", ");
                if (commands[0] == "Add")
                {
                    if (!cardsNames.Contains(commands[1]))
                    {
                        cardsNames.Add(commands[1]);
                        Console.WriteLine($"Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine($"Card is already in the deck");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (cardsNames.Contains(commands[1]))
                    {
                        cardsNames.Remove(commands[1]);
                        Console.WriteLine($"Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine($"Card not found");
                    }
                }
                else if (commands[0] == "Remove At")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < cardsNames.Count)
                    {
                        cardsNames.RemoveAt(index);
                        Console.WriteLine($"Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine($"Index out of range");
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < cardsNames.Count)
                    {
                        if (!cardsNames.Contains(commands[2]))
                        {
                            cardsNames.Insert(index, commands[2]);
                            Console.WriteLine($"Card successfully added");
                        }
                        else
                        {
                            Console.WriteLine($"Card is already added");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ",cardsNames));
        }
    }
}
