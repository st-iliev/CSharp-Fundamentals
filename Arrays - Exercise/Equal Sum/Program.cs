using System;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            int elementIndex = 0;
            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum1 = 0;
                    sum2 = 0;
                    if (i == 0)
                    {
                        sum1 = 0;
                        for (int x = i + 1; x <= numbers.Length - 1; x++)
                        {
                            sum2 += numbers[x];
                        }
                    }
                    else
                    {

                        for (int z = i - 1; z >= 0; z--)
                        {
                            sum1 += numbers[z];
                        }
                        for (int r = i + 1; r <= numbers.Length - 1; r++)
                        {
                            sum2 += numbers[r];
                        }
                    }
                        if (sum1 == sum2)
                    {
                        elementIndex = i;
                        break;
                    }
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine(elementIndex);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
