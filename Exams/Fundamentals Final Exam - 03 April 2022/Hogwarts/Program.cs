using System;
using System.Text;

namespace Programming_Fundamentals_Final_Exam___03_April_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "Abracadabra")
            {
                if (commands[0] == "Abjuration")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (Char.IsLetter(input[i]))
                        {
                            char currentChar = char.ToUpper(input[i]);
                            input.Replace(input[i], currentChar);
                        }
                    }
                    Console.WriteLine(input.ToString());
                }
                else if (commands[0] == "Necromancy")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (Char.IsLetter(input[i]))
                        {
                            char currentChar = char.ToLower(input[i]);
                            input.Replace(input[i], currentChar);
                        }
                    }
                    Console.WriteLine(input.ToString());
                }
                else if (commands[0] == "Illusion")
                {
                    int index = int.Parse(commands[1]);
                    char letter = char.Parse(commands[2]);
                    if (index >= 0 && index <= input.Length - 1)
                    {
                        input.Insert(index, letter);
                        input.Remove(index + 1, 1);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine($"The spell was too weak.");
                    }
                }
                else if (commands[0] == "Divination")
                {
                    if (input.ToString().Contains(commands[1]))
                    {
                        int index = input.ToString().IndexOf(commands[1]);
                        while (index != -1)
                        {
                            input.Replace(commands[1], commands[2], index, commands[1].Length);
                            index = input.ToString().IndexOf(commands[1]);
                        }
                        Console.WriteLine(input.ToString());
                    }
                }
                else if (commands[0] == "Alteration")
                {
                    if (input.ToString().Contains(commands[1]))
                    {
                        int index = input.ToString().IndexOf(commands[1]);
                        input.Remove(index, commands[1].Length);
                        Console.WriteLine(input.ToString());
                    }
                }
                else
                {
                    Console.WriteLine($"The spell did not work!");
                }
                    commands = Console.ReadLine().Split();
            }
        }
    }
}
