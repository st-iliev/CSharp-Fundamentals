using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            while (text != "End")
            {
                string[] command = text.Split();
                int element = 0;
                int index = 0;
                if (command.Length == 2)
                {
                    if (command[0] == "Add")
                    {
                        element = int.Parse(command[1]);
                        numbers.Add(element);
                    }
                    else if(command[0]== "Remove")
                    {
                        index = int.Parse(command[1]);
                        if (index <= numbers.Count - 1 && index >= 0)
                        {
                            numbers.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                            text = Console.ReadLine();
                            continue;
                        }
                    }
                }
                else if (command.Length == 3)
                {
                    if (command[0] == "Insert")
                    {
                        element = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        if (index <= numbers.Count - 1 && index >=0)
                        {
                            numbers.Insert(index, element);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                            text = Console.ReadLine();
                            continue;
                        }
                    }
                    else if (command[0] == "Shift" && command[1] == "left")
                    {
                        index = int.Parse(command[2]);
                        for (int i = 0; i < index; i++)
                        {
                            int num = numbers[0];
                            numbers.RemoveAt(0);                
                            numbers.Add(num);
                        }
                    }
                    else if (command[0] == "Shift" && command[1] == "right")
                    {
                        index = int.Parse(command[2]);
                        for (int i = 0; i < index; i++)
                        {
                            int num = numbers[numbers.Count-1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, num);
                        }
                    }
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

    }
}


