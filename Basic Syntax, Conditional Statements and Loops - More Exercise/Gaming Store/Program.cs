using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gameName = "";
            double spent = 0;
            while (true)
            {
               gameName = Console.ReadLine();
                if (gameName == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${budget:F2}");
                    break;
                }
                if (gameName == "OutFall 4" || gameName == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        spent +=39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        budget -= 15.99;
                        spent += 15.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (budget >= 19.99)
                    {
                        budget -= 19.99;
                        spent += 19.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        budget -= 59.99;
                        spent += 59.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        budget -= 29.99;
                        spent += 29.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine($"Not Found");
                }
                if (budget == 0)
                {
                    Console.WriteLine($"Out of money!");
                    break;
                }

            }
        }
    }
}

