using System;

namespace _04._Programming_Fundamentals_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commands = Console.ReadLine().Split();
            while (commands[0]!="Done")
            {
                if (commands[0] == "TakeOdd")
                {
                    string rawPassword = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            rawPassword += input[i];
                        }
                    }
                    input = rawPassword;
                    Console.WriteLine(input);
                }
                else if (commands[0] == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);
                    string currentSubstring = input.Substring(index, length);
                    int firstOccurrence = input.IndexOf(currentSubstring);
                    string cuttingInput = input.Remove(index, length);
                    input = cuttingInput;
                    Console.WriteLine(input);
                }
                else if (commands[0] == "Substitute")
                {
                    string substring = commands[1];
                    string substitute = commands[2];
                    if (input.Contains(substring))
                    {
                        string replacedInput = input.Replace(substring, substitute);
                        input = replacedInput;
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }
                    commands = Console.ReadLine().Split();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
