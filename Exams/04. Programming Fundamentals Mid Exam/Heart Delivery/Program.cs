using System;
using System.Linq;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hearts = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            int currentIndex = 0;
            while (command[0] != "Love!")
            {
                int length = int.Parse(command[1]);
                if (length + currentIndex > hearts.Count-1)
                {
                    length = 0;
                    currentIndex = 0;
                }
                else
                {
                    currentIndex += length;
                }
                if (hearts[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                    if (hearts[currentIndex] -2 == 0)
                    {
                        hearts[currentIndex] -= 2;
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                    else
                    {
                        hearts[currentIndex] -= 2;
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            int failCounter = 0;
            for (int i = 0; i < hearts.Count; i++)
            {
                if (hearts[i] != 0)
                {
                    failCounter++;
                }
            }
            if (failCounter >0)
            {
                Console.WriteLine($"Cupid has failed {failCounter} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}

