using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double sum = Math.Abs(firstNumber - secondNumber);
            if(sum>eps)
            {
                Console.WriteLine($"False");
            }
            else
            {
                Console.WriteLine($"True");
            }
           
        }
    }
}
