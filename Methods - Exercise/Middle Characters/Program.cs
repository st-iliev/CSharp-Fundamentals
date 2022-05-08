using System;

namespace _6
{
    class Program
    {
        static void PrintMiddleCharacterInString(string text)
        {
            if (text.Length % 2 == 1)
            {
                int index = (text.Length - 1)/2;
                Console.WriteLine(text[index]);
            }
            else
            {
                int index1 = (text.Length - 1)/2;
                int index2 = index1 + 1;
                Console.WriteLine($"{text[index1]}{text[index2]}");
            }
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacterInString(text);
        }
    }
}
