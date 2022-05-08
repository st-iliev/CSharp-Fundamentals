using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                string numbers = Console.ReadLine();
                string firstNumber = "";
                string secondNumber = "";
                long convertFirstNumber = 0;
                long convertSecondNumber = 0;
                long result = 0;
                bool switchNumbers = false;
                for (int z = 0; z <= numbers.Length - 1; z++)
                {
                    if (numbers[z] == ' ')
                    {
                        switchNumbers = true;
                        continue;
                    }
                    if (!switchNumbers)
                    {
                        firstNumber += numbers[z];
                    }
                    else
                    {
                        secondNumber += numbers[z];
                    }

                }
                convertFirstNumber = Convert.ToInt64(firstNumber);
                convertSecondNumber = Convert.ToInt64(secondNumber);
                if (convertFirstNumber > convertSecondNumber)
                {
                    while (convertFirstNumber != 0)
                    {
                        result += convertFirstNumber % 10;
                        convertFirstNumber = convertFirstNumber / 10;
                    }
                }
                else
                {
                    while (convertSecondNumber != 0)
                    {
                        result += convertSecondNumber % 10;
                        convertSecondNumber = convertSecondNumber / 10;
                    }
                }
                Console.WriteLine(Math.Abs(result));
            }
        }
    }
}
