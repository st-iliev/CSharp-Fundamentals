using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = number;
            int factorialSum = 0;
            while (num > 0)
            {
                int factorial = 1;
                int digit = num % 10;
                num = num / 10;
                for (int i = 2; i <= digit; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }  
            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
