using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderNumbers = int.Parse(Console.ReadLine());
            decimal totalSum = 0;
            for (int i = 1; i <= orderNumbers; i++) 
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                decimal price = ((daysInMonth * capsuleCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
                totalSum += price;
            }
            Console.WriteLine($"Total: ${totalSum:F2}");

        }
    }
}
