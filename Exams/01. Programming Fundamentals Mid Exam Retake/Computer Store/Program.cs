using System;

namespace _01._Programming_Fundamentals_Mid_Exam_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "";
            double sum = 0;
            double sumWithTaxes = 0;
            while (true)
            {
                type = Console.ReadLine();
                if (type == "special" || type == "regular")
                {
                    break;
                }
               double pricePart = double.Parse(type);
                if (pricePart < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                sum += pricePart;
            }
            sumWithTaxes = sum + (sum * 0.2);
            if (type == "special")
            {
                sumWithTaxes -= sumWithTaxes * 0.1;
            }
            if (sum > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:F2}$");
                Console.WriteLine($"Taxes: {sum*0.2:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {sumWithTaxes:F2}$");
            }
            else
            {
                Console.WriteLine($"Invalid order!");
            }
        }
    }
}
