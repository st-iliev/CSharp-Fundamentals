using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstText = Console.ReadLine();
            string[] firstArray = firstText.Split();
            string secondText = Console.ReadLine();
            string[] secondArray = secondText.Split();
            for (int i = 0; i < secondArray.Length; i++)
            {

                for (int r = 0; r < firstArray.Length; r++)
                {
                    if (secondArray[i] == firstArray[r])
                    {
                        Console.Write(secondArray[i]+ " ");
                    }

                }
            }
        }
    }
}
