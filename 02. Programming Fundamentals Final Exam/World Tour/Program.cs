using System;
using System.Linq;
using System.Text;

namespace _02._Programming_Fundamentals_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder destinations = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(":");
            while (command[0]!="Travel")
            {
                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index <= destinations.Length - 1)
                    {
                        destinations.Insert(index, command[2]);
                    }
                    Console.WriteLine(destinations);
                }
                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex >= 0 && startIndex <= destinations.Length - 1 && endIndex >= 0 && endIndex <= destinations.Length - 1)
                    {
                        destinations.Remove(startIndex, endIndex - startIndex+1);
                    }
                    Console.WriteLine(destinations);
                }
                else if (command[0] == "Switch")
                {
                    destinations = destinations.Replace(command[1], command[2]);
                    Console.WriteLine(destinations);
                }
                    command = Console.ReadLine().Split(":");
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
