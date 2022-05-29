using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!").ToList();
            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "Go" && commands[1] != "Shopping!")
            {
                if (commands[0] == "Urgent")
                {
                    bool isFind = false;
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (commands[1] == products[i])
                        {
                            isFind = true;
                            break;
                        }
                    }
                    if (!isFind)
                    {
                        products.Insert(0, commands[1]);
                    }
                }
                else if (commands[0] == "Unnecessary")
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (commands[1] == products[i])
                        {
                            products.Remove(commands[1]);
                            break;
                        }

                    }
                }
                else if (commands[0] == "Correct")
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (commands[1] == products[i])
                        {
                            products[i] = commands[2];
                            break;
                        }
                    }
                }
                else if (commands[0] == "Rearrange")
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (commands[1] == products[i])
                        {
                            string currentProduct = products[i];
                            products.RemoveAt(i);
                            products.Add(currentProduct);
                            break;
                        }
                    }
                }
                commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(", ", products));
        }
    }
}
