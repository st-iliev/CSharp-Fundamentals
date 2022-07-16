using System;

namespace _04._Programming_Fundamentals_Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal weightOfPig = decimal.Parse(Console.ReadLine());
            int dayCount = 0;
            while (dayCount < 30)
            {
                dayCount++;
                food -= 0.3M;
                if (food <= 0)
                {
                    break;
                }
                if (dayCount % 2 == 0)
                {
                    hay -= food * 0.05M;
                    if (hay <= 0)
                    {
                        break;
                    }
                }
                if (dayCount % 3 == 0 && dayCount != 1)
                {
                    cover -= weightOfPig * (1 / 3.0M);
                    if (cover <= 0)
                    {
                        break;
                    }
                }
            }
            if (food > 0 && hay > 0 && cover > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }

        }
    }
}
