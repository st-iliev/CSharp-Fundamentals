using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                    letters[letter] = 0;
                    }
                    letters[letter]++;
                }
            }
            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
