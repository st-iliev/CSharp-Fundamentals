using System;

namespace _2
{
    class Program
    {
        static void PrintNumberOfVowel(int count,string text)
        {
            for (int i = 0; i <= text.Length-1; i++)
            {
                char letter = text[i];
                if (letter == 'A' || letter == 'O' || letter == 'E' ||
                    letter == 'I' || letter == 'U' || letter == 'a' ||
                    letter == 'o' || letter == 'e' || letter == 'i' ||
                    letter == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = 0;
            PrintNumberOfVowel(count,text);
        }
    }
}
