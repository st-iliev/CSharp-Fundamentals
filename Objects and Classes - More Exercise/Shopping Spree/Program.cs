using System;
using System.Collections.Generic;

namespace _5
{
    class Person
    {
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<string>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> Bag { get; set; }
        public string ProductsInBag(string name, double cost)
        {
            if (cost <= Money)
            {
                Money -= cost;
                Bag.Add(name);
                return Name + " " + "bought" + " " + name;
            }
            else
            {
                return Name + " " + "can't afford" + " " + name;
            }

        }
    }
    class Product
    {
        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            string[] people = Console.ReadLine().Split(";");
            for (int i = 0; i < people.Length; i++)
            {
                string name = people[i].Split("=")[0];
                double money = double.Parse(people[i].Split("=")[1]);
                Person person = new Person(name, money);
                persons.Add(person);
            }
            string[] product = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < product.Length; i++)
            {
                string name = product[i].Split("=")[0];
                double cost = double.Parse(product[i].Split("=")[1]);
                Product currentProduct = new Product(name, cost);
                products.Add(currentProduct);
            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                string personName = command[0];
                string productName = command[1];
                foreach (var item in persons)
                {
                    if (item.Name == personName)
                    {
                        foreach (var prod in products)
                        {
                            if (prod.Name == productName)
                            {
                                Console.WriteLine($"{item.ProductsInBag(prod.Name, prod.Cost)}");
                            }
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }
            foreach (var item in persons)
            {
                if (item.Bag.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.Bag)}");
                }
            }
        }
    }
}
