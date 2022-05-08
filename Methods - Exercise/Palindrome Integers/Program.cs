using System;

namespace _9
{
    class Program
    {
        static string ReverseString(string palindrome)
        {
            string reversed = "";
            for (int i = palindrome.Length-1; i >=0; i--)
            {
                reversed += palindrome[i];
            }
            return reversed;
        }
        static void PalindromeCheck (string palindrome)
        {
            
            while (palindrome!= "END")
            {
                string reversePalindrome = ReverseString(palindrome);
                if (palindrome == reversePalindrome)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                palindrome = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            string palindrome = Console.ReadLine();
            PalindromeCheck(palindrome);

        }
    }
}
