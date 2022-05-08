using System;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < rotations; i++)
            {
                int element = arrayOfNumbers[0];
                for (int r = 0; r < arrayOfNumbers.Length-1; r++)
                {
                    arrayOfNumbers[r] = arrayOfNumbers[r + 1];
                }
                arrayOfNumbers[arrayOfNumbers.Length - 1] = element;
            }
            Console.WriteLine(string.Join(" ",arrayOfNumbers));
            
        }
    }
}
