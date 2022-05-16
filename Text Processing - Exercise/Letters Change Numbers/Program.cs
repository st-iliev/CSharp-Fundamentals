using System;
using System.Linq;


namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mainStr = Console.ReadLine().Split();
            decimal resultSum = 0;
            for (int i = 0; i < mainStr.Length; i++)
            {
                decimal currentDigit = 0;
                string digit = "";
                decimal strSum = 0;
                string str = mainStr[i];
                if (str == "")
                {
                    continue;
                }
                digit = str.Substring(1, str.Length - 2);
                if (char.IsUpper(str[0]))
                {
                    decimal index = char.ToUpper(str[0]) - 64;
                    currentDigit = Int32.Parse(digit);
                    strSum = currentDigit / index;
                }
                else if (char.IsLower(str[0]))
                {
                    decimal index = char.ToUpper(str[0]) - 64;
                    currentDigit = Int32.Parse(digit);
                    strSum = currentDigit * index;
                }
                if (char.IsUpper(str[str.Length - 1]))
                {
                    decimal index = char.ToUpper(str[str.Length - 1]) - 64;
                    strSum -= index;
                }
                else if (char.IsLower(str[str.Length - 1]))
                {
                    decimal index = char.ToUpper(str[str.Length - 1]) - 64;
                    strSum += index;
                }
                resultSum += strSum;
            }
            Console.WriteLine($"{Math.Round(resultSum, 2,MidpointRounding.AwayFromZero):F2}");

        }
    }
}
