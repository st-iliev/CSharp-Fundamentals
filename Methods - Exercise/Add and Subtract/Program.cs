using System;

namespace _5
{
    class Program
    {
        static int Addition(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int Subtract(int a ,int b,int c)
        {
            int sum = Addition(a, b);
           int result = sum - c;
            return result;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(a,b,c));
        }
    }
}
