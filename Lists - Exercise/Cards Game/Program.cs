using System;
using System.Collections.Generic;
using System.Linq;


namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList(); 
            int sum = 0;
            while (true)
            {
                if (firstDeck.Count == 0)
                {
                    break;
                }
                else if (secondDeck.Count == 0)
                {
                    break;
                }
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(secondDeck[0]);
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    secondDeck.Add(firstDeck[0]);
                    secondDeck.Add(secondDeck[0]);
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }
            if (firstDeck.Count > secondDeck.Count)
            {
                for (int i = 0; i < firstDeck.Count; i++)
                {
                    sum += firstDeck[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                for (int i = 0; i < secondDeck.Count; i++)
                {
                    sum += secondDeck[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }

        }
    }
}

