using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            string regex = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+[.]?[\d]+)?\$";
            double totalPrice = 0;
            Dictionary<string, Dictionary<string, double>> customers = new Dictionary<string, Dictionary<string, double>>();
            while (order!="end of shift")
            {
                Match matched = Regex.Match(order, regex);
            if (matched.Success)
                {
                    string name = matched.Groups["name"].Value;
                    string product = matched.Groups["product"].Value;
                    int count = int.Parse(matched.Groups["count"].Value);
                    double price = double.Parse(matched.Groups["price"].Value);
                    double productPrice = count * price;
                    totalPrice += productPrice;
                    Console.WriteLine($"{name}: {product} - {productPrice:F2}");
                }
                order = Console.ReadLine();
            }
            
            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}
