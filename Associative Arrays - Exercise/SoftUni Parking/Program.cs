using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string reg = commands[0];
                string name = commands[1];
                string licenseNumber = "";
                if (commands.Length == 3)
                {
                    licenseNumber = commands[2];
                }
                if (reg == "register")
                {
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                    }
                    else if (!users.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} registered {licenseNumber} successfully");
                        users.Add(name, licenseNumber);
                    }
                }
                else if (reg == "unregister")
                {
                    if (!users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else if (users.ContainsKey(name))
                    {
                        users.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
