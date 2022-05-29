using System;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            string regex = @"@([#]+)(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])@([#]+)";
            for (int i = 0; i < numberOfProducts; i++)
            {
                string barcode = Console.ReadLine();
                Match product = Regex.Match(barcode, regex);
                if (product.Success)
                {
                    string currentProduct = product.Groups["product"].Value;
                    string productGroup = "";
                    foreach (var letter in currentProduct)
                    {
                        if (char.IsDigit(letter))
                        {
                            productGroup += letter;
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                    Console.WriteLine($"Product group: {productGroup}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid barcode");
                }
            }
        }
    }
}
