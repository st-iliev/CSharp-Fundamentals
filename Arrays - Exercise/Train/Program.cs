using System;
using System.Linq;

namespace Exercise_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] trainWagons = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                trainWagons[i] = int.Parse(Console.ReadLine());
                sum += trainWagons[i];
            }
            Console.WriteLine($"{string.Join(' ',trainWagons)}");
            Console.WriteLine(sum);
        }
    }
}
