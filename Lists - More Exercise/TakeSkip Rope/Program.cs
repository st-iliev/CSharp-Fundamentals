using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> text = Console.ReadLine().ToList();
            List<int> numbersList = new List<int>();
            List<char> nonNumbersList = new List<char>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            List<char> result = new List<char>();


            for (int i = 0; i < text.Count; i++)
            {
                if (text[i] != '0' && text[i] != '1' && text[i] != '2' &&
                    text[i] != '3' && text[i] != '4' && text[i] != '5' &&
                    text[i] != '6' && text[i] != '7' && text[i] != '8' &&
                    text[i] != '9')

                {
                    nonNumbersList.Add(text[i]);
                }
                else
                {
                    int digit = (int)char.GetNumericValue(text[i]);
                    numbersList.Add(digit);
                }
            }
            
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }
            for (int i = 0; i < takeList.Count; i++)
            {
                if (takeList[i] > 0)
                {
                    for (int r = 0; r < takeList[i]; r++)
                    {
                        if (r > nonNumbersList.Count - 1)
                        {
                            break;
                        }
                        result.Add(nonNumbersList[r]);
                    }
                }
                if (skipList[i] >= 0)
                {
                    if (takeList[i] + skipList[i] > nonNumbersList.Count)
                    {
                        break;
                    }
                    nonNumbersList.RemoveRange(0, takeList[i] + skipList[i]);
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]}");
            }
            Console.WriteLine();
        }
    }
}
