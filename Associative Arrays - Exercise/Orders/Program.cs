using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {         
            Dictionary<string,double> order = new Dictionary<string,double>();
            Dictionary<string,int> secondOrder = new Dictionary<string,int>();
            string[] productInfo = Console.ReadLine().Split().ToArray();
            while (productInfo[0] != "buy")
            {
                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);
                if (!order.ContainsKey(name))
                {
                    order.Add(name,price);
                    secondOrder.Add(name,quantity);
                    
                }
                else if (order.ContainsKey(name))
                {
                    order.Remove(name);
                    order.Add(name, price);
                    secondOrder[name] += quantity;
                }
                productInfo = Console.ReadLine().Split().ToArray();
            }
            foreach (var item in order)
            {
                foreach (var product in secondOrder)
                {
                    if (item.Key == product.Key)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value * product.Value:F2}");
                    }
                }
            }
        }
    }
}
