using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int countOpenBracket = 0;
            int countCloseBracket = 0;
            bool balanced = true;
            for (int i = 1; i <= lines; i++)
            {
                string symbols = Console.ReadLine();
                if (symbols == "(")
                {
                    countOpenBracket++;
                }
                else if (symbols == ")")
                {
                    countCloseBracket++;
                    if (countCloseBracket > countOpenBracket)
                    {
                        balanced = false;
                    }
                }
            }
            if (countOpenBracket == countCloseBracket && balanced == true)
            {
                Console.WriteLine($"BALANCED");
            }
            else
            {
                Console.WriteLine($"UNBALANCED");
            }
        }
    }
}
