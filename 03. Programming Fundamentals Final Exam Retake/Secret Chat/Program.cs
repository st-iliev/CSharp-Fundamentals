using System;
using System.Linq;
using System.Text;

namespace _03._Programming_Fundamentals_Final_Exam_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder concealedMessage = new StringBuilder(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(":|:");
            while (commands[0]!="Reveal")
            {
                if (commands[0] == "InsertSpace")
                {
                    concealedMessage.Insert(int.Parse(commands[1]), " ");
                    Console.WriteLine(concealedMessage.ToString());
                }
                else if (commands[0] == "Reverse")
                {
                    string reversed = "";
                    string substring = commands[1].ToString();
                    for (int i = substring.Length-1; i >= 0; i--)
                    {
                        reversed += substring[i];
                    }
                    if (concealedMessage.ToString().Contains(commands[1]))
                    {
                        int firstOccurrence = concealedMessage.ToString().IndexOf(commands[1].ToString());
                        concealedMessage.Remove(firstOccurrence, substring.Length);
                        concealedMessage.Append(reversed);
                        Console.WriteLine(concealedMessage.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }
                else if (commands[0] == "ChangeAll")
                {
                    concealedMessage.Replace(commands[1], commands[2]);
                    Console.WriteLine(concealedMessage.ToString());
                }
                    commands = Console.ReadLine().Split(":|:");    
            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
