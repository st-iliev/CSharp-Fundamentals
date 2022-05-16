using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int reminder = 0;
            StringBuilder finalString = new StringBuilder();
            if(number == "0" || multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = number.Length-1; i >= 0; i--)
            {
                int curentDigit = int.Parse(number[i].ToString());
                int product = curentDigit * multiplier + reminder;
                int result = product % 10;
                reminder = product / 10;
                finalString.Insert(0, result);
            }
            if (reminder > 0)
            {
                finalString.Insert(0, reminder.ToString());
            }
            Console.WriteLine(finalString);
        }
    }
}
