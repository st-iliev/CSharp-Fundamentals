using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    wagons.Add(Convert.ToInt32(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (Convert.ToInt32(command[0]) + wagons[i] <= capacity)
                        {
                            wagons[i] += Convert.ToInt32(command[0]);
                            break;

                        }
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
