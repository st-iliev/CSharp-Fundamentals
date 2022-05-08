using System;

namespace _10
{
    class Program
    {
        static void FindTopNumbers(int number)
        {
            
            for (int i = 1; i <= number; i++)
            {
                bool divideCheck = false;
                bool oddDigitCheck = false;
                int sum = 0;
                int check = i;
                if (check >= 10)
                {

                    while (check > 0)
                    {
                        int digit = check % 10;
                        if (digit % 2 == 1)
                        {
                            oddDigitCheck = true;
                        }
                        sum += digit;
                        check /= 10;
                    }
                }
                    if (sum % 8 == 0)
                {
                    divideCheck = true;
                }
                if(divideCheck && oddDigitCheck)
                {
                    Console.WriteLine(i);
                }

            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FindTopNumbers(number);
        }
    }
}
