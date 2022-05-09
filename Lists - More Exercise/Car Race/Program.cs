using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] racersTime = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double timeOfFirstRacer = 0;
            double timeOfSecondRacer = 0;
            for (int i = 0; i < racersTime.Length/2; i++)
            {
                if (racersTime[i] == 0)
                {
                    timeOfFirstRacer -= timeOfFirstRacer*0.2;
                }
                else
                {
                    timeOfFirstRacer += racersTime[i];
                }
            }
            for (int i = racersTime.Length-1; i > racersTime.Length/2; i--)
            {
                if (racersTime[i] == 0)
                {
                    timeOfSecondRacer -= timeOfSecondRacer * 0.2;
                }
                else
                {
                    timeOfSecondRacer += racersTime[i];
                }
            }
            if (timeOfFirstRacer <= timeOfSecondRacer)
            {
                Console.WriteLine($"The winner is left with total time: {timeOfFirstRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeOfSecondRacer}");
            }
        }
    }
}
