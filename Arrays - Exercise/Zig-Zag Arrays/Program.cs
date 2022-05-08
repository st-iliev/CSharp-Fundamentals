using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[1];
            string[] array = new string[n * 2];
            string[] evenArray = new string[n];
            string[] oddArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int r = 0; r < 1; r++)
                {
                    if (i%2!=0)
                    {
                        oddArray[i] += numbers[0];
                        evenArray[i] += numbers[1];
                        
                    }
                    else 
                    {
                        oddArray[i] += numbers[1];
                        evenArray[i] += numbers[0];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", evenArray));
            Console.WriteLine(string.Join(" ", oddArray));

        }
    }
}
