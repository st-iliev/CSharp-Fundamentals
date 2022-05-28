using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            double average = sequenceNumbers.Average();
            foreach (var item in sequenceNumbers)
            {
                if (item > average)
                {
                    result.Add(item);
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ",result.OrderByDescending(s=>s).Take(5)));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
