using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            List<char> result = new List<char>();
            foreach (var item in arr)
            {  
                     result.Add((char)(item + 3));
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
