using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = "";
            int count = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i].ToString();
            }
            while (true)
            {
                string password = Console.ReadLine();
                if (pass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }
        }
    }
}
