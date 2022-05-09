using System;
using System.Linq;
using System.Collections.Generic;


namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while(command[0]!="end")
            {
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == Convert.ToInt32(command[1]))
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(Convert.ToInt32(command[2]), Convert.ToInt32(command[1]));
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
