using System;
using System.Collections.Generic;

namespace Text_Processing___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStrings; i++)
            {
                string text = Console.ReadLine();
                int nameStart = text.IndexOf("@");
                int nameEnd = text.IndexOf("|");
                string name = text.Substring(nameStart + 1, nameEnd - 1 - nameStart);
                int ageStart = text.IndexOf("#");
                int ageEnd = text.IndexOf("*");
                string age = text.Substring(ageStart+1, ageEnd-1- ageStart);
                Console.WriteLine($"{name} is {age} years old.");
            }
            
        }
    }
}
