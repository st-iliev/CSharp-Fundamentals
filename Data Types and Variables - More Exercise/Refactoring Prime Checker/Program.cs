using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                int countPrime = 0;
                for (int z = 1; z <= i; z++)
                {
                    if (i % z == 0)
                    {
                        countPrime++;
                    }
                }
                if (countPrime == 2)
                {
                Console.WriteLine($"{i} -> true");
                    countPrime = 0;
                }
                else
                {
                Console.WriteLine($"{i} -> false");
                }
            }

        }
    }
}
