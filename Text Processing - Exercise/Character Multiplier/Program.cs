using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static int SumOfCharInTwoStrings(string[] str)
        {
            string first = str[0];
            string second = str[1];
            int longestWord = 0;
            int result = 0;
            if (first.Length >= second.Length)
            {
                longestWord = first.Length;
            }
            else
            {
                longestWord = second.Length;
            }
            for (int i = 0; i < longestWord; i++)
            {
                if (first.Length - 1 >= i)
                {
                    if (second.Length - 1 >= i)
                    {
                        int multiplied = first[i] * second[i];
                        result += multiplied;
                    }
                    else
                    {
                    result += first[i];
                    }
                }
                else if (second.Length-1 >=i)
                {
                    result += second[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            Console.WriteLine($"{SumOfCharInTwoStrings(str)}");
        }
    }
}
