using System;

namespace _7
{
    class Program
    {
        static void Matrix(int number)
        {
            for (int l = 1; l <= number; l++)
            {
                for (int r = 1; r <= number; r++)
                {
                    Console.Write(number+ " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Matrix(number);
        }
    }
}
