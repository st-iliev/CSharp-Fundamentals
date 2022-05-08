using System;

namespace Data_Types_and_Variables___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                if (Int32.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
