using System;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isGreater = false;
            for (int i = 0; i <= numbers.Length-2; i++)
            {
                for (int r = i + 1; r <= numbers.Length-1; r++)
                {
                    if(numbers[i]<=numbers[r])
                    {
                        isGreater = false;
                        break;
                    }
                    else
                    {
                        isGreater = true;
                    }
                }
                if (isGreater)
                {
                Console.Write(numbers[i]+ " ");
                }
            }
            Console.Write(numbers[numbers.Length - 1]);
        }
    }
}
