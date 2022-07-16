using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "end")
            {
                int index1 = 0;
                int index2 = 0;
                if (commands.Count == 3)
                {
                    index1 = int.Parse(commands[1]);
                    index2 = int.Parse(commands[2]);
                }
                if (commands[0] == "swap")
                {
                    int currentElement = numbers[index1];
                    numbers[index1] = numbers[index2];
                    numbers[index2] = currentElement;
                }
                else if (commands[0] == "multiply")
                {
                    numbers[index1] = numbers[index1] * numbers[index2];
                }
                else if (commands[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
