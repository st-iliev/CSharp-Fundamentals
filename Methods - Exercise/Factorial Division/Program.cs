using System;

namespace _8
{
    class Program
    {
        //5!=5x4x3x2x1=120
        static void FacturialOfNumbers(int a , int b)
        {
            decimal firstFacturial = 1;
            decimal secondFacturial = 1;

            for (int i = 1; i <= a; i++)
            {
                firstFacturial *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                secondFacturial *= i;
            }
            decimal result = firstFacturial / secondFacturial;
            Console.WriteLine($"{result:F2}");
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            FacturialOfNumbers(a, b);
        }
    }
}
