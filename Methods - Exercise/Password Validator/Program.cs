using System;

namespace _4
{
    class Program
    {
        static void PasswordValidator(string password)
        {
            bool letterAndDigitValid = false;
            bool digitValid = false;
            bool lengthValid = false;
            int digitCount = 0;
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnm0123456789";
            string digit = "0123456789";
            if (password.Length >= 6 && password.Length <= 10)
            {
                lengthValid = true;
            }
            for (int i = 0; i <= password.Length - 1; i++)
            {
                letterAndDigitValid = false;
                char letter = password[i];
                for (int z = 0; z <= digit.Length-1; z++)          
                {
                    if (letter == digit[z])
                    {
                        digitCount++;
                        if (digitCount >= 2)
                        {
                            digitValid = true;
                        }
                    }
                }
                for (int r = 0; r <= text.Length - 1; r++)
                {
                    if(letter == text[r])
                    {
                        letterAndDigitValid = true;
                    }
                }
                if (!letterAndDigitValid)
                {
                    break;
                }
  
            }
            if (letterAndDigitValid && digitValid && lengthValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!lengthValid)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!letterAndDigitValid)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!digitValid)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }
    }
}
