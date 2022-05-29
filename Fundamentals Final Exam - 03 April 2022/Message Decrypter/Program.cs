using System;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\A([$]|[%])(?<tag>[A-Z]{1}[a-z]{2,})+(\1)(:) ([[](?<firstDigit>[0-9]+)[]][\|][[](?<secondDigit>[0-9]+)[]][\|][[](?<thirdDigit>[0-9]+)[]][\|])$";
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                MatchCollection message = Regex.Matches(input, regex);
                if (message.Count > 0)
                {
                    string currentMessage = "";
                    string tag = "";
                    foreach (Match item in message)
                    {
                        tag = item.Groups["tag"].Value;
                        int firstDigit = int.Parse(item.Groups["firstDigit"].Value);
                        currentMessage += Convert.ToChar(firstDigit);
                        int secondDigit = int.Parse(item.Groups["secondDigit"].Value);
                        currentMessage += Convert.ToChar(secondDigit);
                        int thirdDigit = int.Parse(item.Groups["thirdDigit"].Value);
                        currentMessage += Convert.ToChar(thirdDigit);
                    }
                    Console.WriteLine($"{tag}: {currentMessage}");
                }
                else
                {
                    Console.WriteLine($"Valid message not found!");
                }

            }
           
        }
    }
}
