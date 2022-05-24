using System;
using System.Linq;
using System.Text;

namespace _01._Programming_Fundamentals_Final_Exam_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptMessage = Console.ReadLine();
            string[] command = Console.ReadLine().Split("|");
            while (command[0]!="Decode")
            {
                if (command[0] == "Move")
                {
                    int numbersOfLetters = int.Parse(command[1]);
                    string currentSubstring = encryptMessage.Substring(0, numbersOfLetters);
                   string removedSubstr= encryptMessage.Remove(0, numbersOfLetters);
                    removedSubstr += currentSubstring;
                    encryptMessage = removedSubstr;

                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];
                    string currentMessage = encryptMessage.Insert(index, value);
                    encryptMessage = currentMessage;
                }
                else if (command[0] == "ChangeAll")
                {
                    string currentMessage = "";
                    char substr = char.Parse(command[1].ToString());
                    char replacement = char.Parse(command[2].ToString());
                    foreach (var item in encryptMessage)
                    {
                        if (item == substr)
                        {
                            currentMessage += replacement;
                        }
                        else
                        {
                            currentMessage += item;
                        }
                    }
                    encryptMessage = currentMessage;
                }
                    command = Console.ReadLine().Split("|");
            }
            Console.WriteLine($"The decrypted message is: {encryptMessage}");
        }
    }
}
