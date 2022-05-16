using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regular_Expressions___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = Console.ReadLine();
            string regex = @">>(?<name>[A-Za-z\s]+)+<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            double totalSum = 0;
            List<string> names = new List<string>();
            while (lines != "Purchase")
            {
                Match purchase = Regex.Match(lines, regex, RegexOptions.IgnoreCase);
                if (purchase.Success)
                {
                    string name = purchase.Groups["name"].Value.ToString();
                    double price = double.Parse(purchase.Groups["price"].Value);
                    int quantity = int.Parse(purchase.Groups["quantity"].Value);
                    totalSum += price * quantity;
                    names.Add(name);
                }
                lines = Console.ReadLine();
            } 
            Console.WriteLine($"Bought furniture:");
            names.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }

}
