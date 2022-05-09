using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drumQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> originQuality = drumQuality.ToList();
            List<string> hitPower = Console.ReadLine().Split(", ").ToList();
            while (hitPower[0] != "Hit it again")
            {
                int hit = int.Parse(hitPower[0]);
                for (int i = 0; i < drumQuality.Count; i++)
                {
                    if (drumQuality[i] - hit <= 0)
                    {
                        if (budget >= originQuality[i] * 3)
                        {
                            budget -= originQuality[i] * 3;
                            drumQuality[i] = originQuality[i];
                        }
                        else
                        {
                            drumQuality[i] = 0;

                        }
                    }
                    else
                    {
                        drumQuality[i] -= hit;
                    }
                }
                hitPower = Console.ReadLine().Split(", ").ToList();
            }
            for (int i = 0; i < drumQuality.Count; i++)
            {
                if (drumQuality[i] == 0)
                {
                    drumQuality.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", drumQuality));
            Console.WriteLine($"Gabsy has {budget:F2}lv.");
        }

    }
}

