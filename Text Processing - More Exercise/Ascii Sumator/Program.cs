using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int result = 0;
            string characters = Console.ReadLine();
            foreach (var item in characters)
            {
                if (item > firstChar && item < secondChar)
                {
                    result+= item;
                }
            }
            Console.WriteLine(result);
        }
    }
}
