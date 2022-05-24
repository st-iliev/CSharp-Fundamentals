using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] < 4)
                {
                    if (waitingPeople - (4-wagons[i] )>= 0)
                    {
                    waitingPeople -= 4 - wagons[i];
                    wagons[i] = 4;                       
                    }
                    else if(wagons[i] + waitingPeople <=4)
                    {
                        wagons[i] +=waitingPeople;
                        waitingPeople = 0;
                    }
                    if (waitingPeople == 0)
                    {
                        break;
                    }
                }
            }
            int fullWagons = 0;
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] == 4)
                {
                    fullWagons++;
                }
            }
            if (fullWagons == wagons.Count && waitingPeople == 0)
            {
                Console.WriteLine(string.Join(" ",wagons));
            }
            else if (waitingPeople == 0 && fullWagons < wagons.Count)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (fullWagons == wagons.Count && waitingPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
