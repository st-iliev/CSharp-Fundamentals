using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i =0; i < number; i++)
            {
                char firstCharacter = (char)('a' + i);
                for (int k = 0; k < number; k++)
                {
                    char secondCharacter = (char)('a' + k);
                    for (int z = 0; z < number; z++)
                    {
                        char thirdCharacter = (char)('a' + z);
                        Console.WriteLine($"{firstCharacter}{secondCharacter}{thirdCharacter}");
                    }
                }
            }
        }
    }
}
