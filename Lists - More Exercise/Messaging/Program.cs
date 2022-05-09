using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Lists___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<char> messange = Console.ReadLine().ToList();
            int sumOfElement = 0;
            string removedElements = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                sumOfElement = 0;
                while (numbers[i]>0)
                {
                    int digit = numbers[i] % 10;
                    sumOfElement += digit;
                    numbers[i] /= 10;
                }
                while (sumOfElement > messange.Count-1)
                {
                    sumOfElement -= messange.Count;
                }
                removedElements += messange[sumOfElement];
                messange.RemoveAt(sumOfElement);
            }
            Console.WriteLine(removedElements);
        }
    }
}
