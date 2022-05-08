using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0; ;
            for (int i = num; i <= num1; i++)
            {
                Console.Write(i+" ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
