using System;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sequences = 1;
            int firstIndex = 0;
            int lastIndex = 1;
            int maxSequences = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                sequences = 1;
                for (int r = i+1; r < numbers.Length; r++)
                {
                    if (numbers[i] == numbers[r])
                    {
                        sequences++;
                        if (maxSequences < sequences)
                        {
                            maxSequences = sequences;
                                firstIndex = i;
                                lastIndex = r;
                        }   
                    }
                    else
                    {
                        break;
                    }
                }  
            }
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.Write(numbers[i]+ " ");
            }
        }
    }
}
