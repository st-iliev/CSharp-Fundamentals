using System;

namespace _3
{
    class Program
    {
        static void CharactersBetweenTwoCharacters(char a , char b)
        {
            string result = "";
            if (a > b)
            {
                b++;
                for (char i = b; i < a; i++)
                {
                     result += i;
                    result += " ";
                }
            }
            else
            {
                a++;
                for (char i = a; i < b; i++)
                {
                    result += i;
                    result += " ";
                }
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharactersBetweenTwoCharacters(a, b);
        }
    }
}
