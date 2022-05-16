using System;
using System.Collections.Generic;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> result = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                    if (result.Count == 0)
                    {
                        result.Add(text[i]);
                    }
                    else if (result[result.Count - 1] != text[i])
                    {
                        result.Add(text[i]);
                    }
                
            }
            Console.WriteLine(string.Join("", result));

        }
    }
}
