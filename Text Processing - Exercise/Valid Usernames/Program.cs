using System;
using System.Linq;

namespace Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var item in usernames)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {
                    int count = 0;
                    foreach (var ch in item)
                    {
                        if (char.IsLetterOrDigit(ch))
                        {
                            count++;
                        }
                        else if (ch == '-')
                        {
                            count++;
                        }
                        else if(ch=='_')
                        {
                            count++;
                        }
                    }
                    if (count == item.Length)
                    {
                        Console.WriteLine($"{item}");
                    }
                }
            }
        }
    }
}
