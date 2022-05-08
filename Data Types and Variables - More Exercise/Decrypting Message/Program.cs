using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 1; i <= lines; i++)
            {
                char letter =(char)(char.Parse(Console.ReadLine()) + (char)key);
                word += letter;
            }
            Console.WriteLine(word);
        }
    }
}
