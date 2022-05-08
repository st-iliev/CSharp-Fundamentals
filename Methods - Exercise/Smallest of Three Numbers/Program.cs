using System;

namespace Methods___Exercise
{
    class Program
    {
        static void SmallestNumber(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else if (b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c= int.Parse(Console.ReadLine());
            SmallestNumber(a, b, c);
        }
    }
}
