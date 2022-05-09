using System;
using System.Collections.Generic;
using System.Linq;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int sumOfRemovedElements = 0;
            while (true)
            {
                
                int currentElement = 0;
                if (index < 0)
                {
                    index = 0;
                    currentElement = distance[index];
                    sumOfRemovedElements += currentElement;
                    distance[0] = distance[distance.Count - 1];
                    for (int i = 0; i < distance.Count; i++)
                    {
                        if (currentElement >= distance[i])
                        {
                            distance[i] += currentElement;
                        }
                        else
                        {
                            distance[i] -= currentElement;
                        }
                    }

                }
                else if (index > distance.Count - 1)
                {
                    currentElement = distance[distance.Count - 1];
                    sumOfRemovedElements += currentElement;
                    distance[distance.Count - 1] = distance[0];
                    for (int i = 0; i < distance.Count; i++)
                    {
                        if (currentElement >= distance[i])
                        {
                            distance[i] += currentElement;
                        }
                        else
                        {
                            distance[i] -= currentElement;
                        }
                    }
                }
                else if (index >= 0 && index <= distance.Count - 1)
                {

                    currentElement = distance[index];
                    sumOfRemovedElements += currentElement;
                    distance.RemoveAt(index);
                    if (distance.Count == 0)
                    {
                        break;
                    }
                    for (int i = 0; i < distance.Count; i++)
                    {
                        if (currentElement >= distance[i])
                        {
                            distance[i] += currentElement;
                        }
                        else
                        {
                            distance[i] -= currentElement;
                        }
                    }
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
