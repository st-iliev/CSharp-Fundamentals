using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = 0;
            double sum = 0;
            string text = "";
            while (true)
            {
                text = Console.ReadLine();
                if (text == "Start")
                {
                    break;
                }
                coins = double.Parse(text);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            while (sum > 0)
            {
                string purchase = Console.ReadLine();
                if (purchase == "End")
                {
                    break;
                }
                switch (purchase)
                {
                    case "Nuts":
                        if (sum - 2 >= 0)
                        {
                            Console.WriteLine($"Purchased nuts");
                            sum -= 2;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum - 0.7 >= 0)
                        {
                            Console.WriteLine($"Purchased water");
                            sum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sum - 1.5 >= 0)
                        {
                            Console.WriteLine($"Purchased crisps");
                            sum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sum - 0.8 >= 0)
                        {
                            Console.WriteLine($"Purchased soda");
                            sum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum - 1 >= 0)
                        {
                            Console.WriteLine($"Purchased coke");
                            sum -= 1;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        break;
                }
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
