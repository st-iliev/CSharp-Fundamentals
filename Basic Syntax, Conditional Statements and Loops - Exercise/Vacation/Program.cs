using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            if (groupType == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = peopleNum * 8.45;
                        break;
                    case "Saturday":
                        price = peopleNum * 9.80;
                        break;
                    case "Sunday":
                        price = peopleNum * 10.46;
                        break;
                }
                if (peopleNum >= 30)
                {
                    price -= price * 0.15;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleNum >= 100)
                {
                    peopleNum -= 10;
                }
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = peopleNum * 10.9;
                        break;
                    case "Saturday":
                        price = peopleNum * 15.6;
                        break;
                    case "Sunday":
                        price = peopleNum * 16;
                        break;
                }

            }
            else if (groupType == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = peopleNum * 15;
                        break;
                    case "Saturday":
                        price = peopleNum * 20;
                        break;
                    case "Sunday":
                        price = peopleNum * 22.5;
                        break;
                }
                if (peopleNum >= 10 && peopleNum <= 20)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
