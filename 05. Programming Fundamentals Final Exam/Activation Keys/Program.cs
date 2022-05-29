using System;
using System.Text;

namespace _05._Programming_Fundamentals_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(">>>");
            while (commands[0]!="Generate")
            {
                if (commands[0] == "Contains")
                {
                    if (activationKey.ToString().Contains(commands[1]))
                    {
                        Console.WriteLine($"{activationKey} contains {commands[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (commands[0] == "Flip")
                {
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);
                    string currentSubstring = activationKey.ToString().Substring(startIndex, endIndex - startIndex);
                    string changedSubstring = "";
                    foreach (var item in currentSubstring)
                    {
                        if (commands[1]=="Upper")
                        {
                            changedSubstring += char.ToUpper(item);
                        }
                        else if (commands[1]=="Lower")
                        {
                            changedSubstring += char.ToLower(item);
                        }  
                    }
                    activationKey.Replace(currentSubstring, changedSubstring);
                    Console.WriteLine($"{activationKey}");
                }
                else if (commands[0] == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine($"{activationKey}");
                }
                    commands = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
