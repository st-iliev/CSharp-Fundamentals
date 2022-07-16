using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetsValue = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "End")
            {
                int index1 = int.Parse(commands[1]);
                int index2 = int.Parse(commands[2]);
                if (commands[0] == "Shoot")
                {
                    if (index1 >= 0 && index1 < targetsValue.Count)
                    {
                        targetsValue[index1] -= index2;
                        if (targetsValue[index1] <= 0)
                        {
                            targetsValue.RemoveAt(index1);
                        }
                    }
                }
                else if (commands[0] == "Add")
                {
                    if (index1 >= 0 && index1 < targetsValue.Count)
                    {
                        targetsValue.Insert(index1, index2);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                }
                else if (commands[0] == "Strike")
                {
                    if (index1 - index2 >= 0 && index1 + index2 < targetsValue.Count)
                    {  
                            targetsValue.RemoveRange(index1 - index2, 1+index2 * 2);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }
                    commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join("|",targetsValue));
        }
    }
}
