using System;
using System.Linq;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int r = i +1; r <= numbers.Length-1; r++)
                {
                    if(numbers[i]+numbers[r]==magicSum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[r]}");
                    }
                }
            }
        }
    }
}
