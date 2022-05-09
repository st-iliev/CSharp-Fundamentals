using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int el = numbers.IndexOf(bombPower[0]);
                int bombCount = 0;
                if (bombPower[0] == numbers[i])
                {
                    bombCount++;
                    list.Clear();
                    for (int r = 1; r <= bombPower[1]; r++)
                    {
                        if (el - r >= 0)
                        {
                            list.Add(numbers[el - r]);

                        }
                        if (el + r <= numbers.Count - 1)
                        {
                            list.Add(numbers[el + r]);
                        }
                    }
                    for (int z = 0; z < bombCount; z++)
                    {
                        numbers.Remove(bombPower[0]);
                    }
                    for (int x = 0; x < list.Count; x++)
                    {
                        numbers.Remove(list[x]);
                    }
                    i = -1;
                }            
            }    
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);           
        }
    }
}
