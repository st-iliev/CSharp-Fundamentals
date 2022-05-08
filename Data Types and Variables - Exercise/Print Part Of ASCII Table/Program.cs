using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCharacter = int.Parse(Console.ReadLine());
            int lastCharacter = int.Parse(Console.ReadLine());
            for (char i = (char)firstCharacter; i <= (char)lastCharacter; i++)
            {
                Console.Write(i+ " ");
            }
        }
    }
}
