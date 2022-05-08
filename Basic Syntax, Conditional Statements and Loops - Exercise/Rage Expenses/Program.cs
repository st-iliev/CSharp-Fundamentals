using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headset = float.Parse(Console.ReadLine());
            float mouse = float.Parse(Console.ReadLine());
            float keyboard = float.Parse(Console.ReadLine());
            float display = float.Parse(Console.ReadLine());
            int headsetCount= 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if(i%3 == 0)
                {
                    mouseCount++;
                }
                if(i%2 == 0 && i%3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }
            double headsetPrice = headsetCount * headset;
            double mousePrice = mouseCount * mouse;
            double keyboardPrice = keyboardCount * keyboard;
            double displayPrice = displayCount * display;
            double sum = headsetPrice + mousePrice + keyboardPrice + displayPrice;
            Console.WriteLine($"Rage expenses: {sum:F2} lv.");
        }
    }
}
