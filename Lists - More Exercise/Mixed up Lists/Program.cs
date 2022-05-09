using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int lowerCount = 0;
            int firstElement = 0;
            int secondElement = 0;
            List<int> resultList = new List<int>();
            List<int> finalList = new List<int>();
            if (firstList.Count > secondList.Count)
            {
                lowerCount = secondList.Count;
                if (firstList[firstList.Count - 1] >= firstList[firstList.Count - 2])
                {
                    firstElement = firstList[firstList.Count - 1];
                    secondElement = firstList[firstList.Count - 2];
                    firstList.RemoveAt(firstList.Count - 2);
                    firstList.RemoveAt(firstList.Count - 1);
                }
                else
                {
                    firstElement = firstList[firstList.Count - 2];
                    secondElement = firstList[firstList.Count - 1];
                    firstList.RemoveAt(firstList.Count - 2);
                    firstList.RemoveAt(firstList.Count - 1);
                }

            }
            else
            {
                lowerCount = firstList.Count;
                if (secondList[0] >= secondList[1])
                {
                    firstElement = secondList[0];
                    secondElement = secondList[1];
                    secondList.RemoveAt(1);
                    secondList.RemoveAt(0);
                }
                else
                {
                    firstElement = secondList[1];
                    secondElement = secondList[0];
                    secondList.RemoveAt(1);
                    secondList.RemoveAt(0);
                }
            }
            for (int i = 0; i < lowerCount; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[secondList.Count - 1 - i]);
            }
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i] < firstElement && resultList[i] > secondElement)
                {
                    finalList.Add(resultList[i]);
                }
            }
            for (int i = 0; i < finalList.Count; i++)
            {
                for (int r = 0 + i; r < finalList.Count; r++)
                {
                    if (finalList[i] > finalList[r])
                    {
                        int digit = finalList[i];
                        finalList[i] = finalList[r];
                        finalList[r] = digit;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
