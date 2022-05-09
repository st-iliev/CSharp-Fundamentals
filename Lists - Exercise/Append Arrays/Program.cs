using System;
using System.Linq;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                result.AddRange(item.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ",result));
           
        }
    }
}
