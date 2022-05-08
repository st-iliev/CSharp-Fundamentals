using System;
using System.Linq;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfLines = int.Parse(Console.ReadLine());
            int[] arr, result = new int[lengthOfLines];
            int max = 0;
            int sample = 0;
            int bestSample = 0;
            int bestIndex = lengthOfLines - 1;
            int longestSubsequence = -1;
            string text = Console.ReadLine();
            int firstIndex = lengthOfLines - 1;
            while (text != "Clone them!")
            {
                arr = text.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                int subsequence = 0;
                int sum = 0;
                bool isGreater = false;
                
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] == 1 && arr[i] == arr[i + 1])
                    {
                        if (i < firstIndex)
                        {
                            firstIndex = i;
                        }
                        subsequence++;
                    }
                }
                sum = arr.Sum();
                if (subsequence > longestSubsequence)
                {
                    isGreater = true;
                }
                else if (subsequence == longestSubsequence)
                {
                    if (firstIndex < bestIndex)
                    {
                        isGreater = true;
                    }
                    else if (firstIndex == bestIndex)
                    {
                        if (sum > max)
                        {
                            isGreater = true;
                        }
                    }
                }
                if (isGreater)
                {
                    result = arr;
                    bestSample = sample;
                    max = sum;
                    longestSubsequence = subsequence;
                    bestIndex = firstIndex;
                }
                text = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {max}.");
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
