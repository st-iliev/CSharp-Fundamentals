using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int tankCapacity = 0;
            for (int i = 1; i <= number; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if(liters+tankCapacity>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                tankCapacity += liters;
                }
            }
            Console.WriteLine(tankCapacity);
        }
    }
}
