using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            List<string> indexes = Console.ReadLine().Split().ToList();
            int movesCount = 0;
            while (indexes[0] != "end")
            {
                int index1 = int.Parse(indexes[0]);
                int index2 = int.Parse(indexes[1]);
                movesCount--;
                string additionElement = "";
                if (index1 < 0 || index1 > elements.Count - 1 ||
                    index2 < 0 || index2 > elements.Count - 1)
                {
                    additionElement = movesCount.ToString();
                    additionElement += "a";
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    elements.Insert(elements.Count / 2, additionElement);
                    elements.Insert(elements.Count / 2+1, additionElement);
                }
                else if (elements[index1] == elements[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    if (index1 > index2)
                    {
                        elements.RemoveAt(index1);
                        elements.RemoveAt(index2);
                    }
                    else
                    {
                        elements.RemoveAt(index2);
                        elements.RemoveAt(index1);
                    }
                }  
                else if (elements[index1] != elements[index2])
                {
                    Console.WriteLine($"Try again!");
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {Math.Abs(movesCount)} turns!");
                    break;
                }
                    indexes = Console.ReadLine().Split().ToList();
            }
            if (elements.Count > 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ",elements));
            }

        }
    }
}
