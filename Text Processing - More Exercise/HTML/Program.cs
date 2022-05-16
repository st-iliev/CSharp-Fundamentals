using System;
using System.Collections.Generic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            string coments = Console.ReadLine();
            List<string> coment = new List<string>();
            while (coments!= "end of comments")
            {
                coment.Add(coments);
                coments = Console.ReadLine();
            }
            Console.WriteLine($"<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine($"</h1>");
            Console.WriteLine($"<article>");
            Console.WriteLine($"    {article}");
            Console.WriteLine($"</article>");
            for (int i = 0; i < coment.Count; i++)
            {
                Console.WriteLine($"<div>");
            Console.WriteLine($"    {coment[i]}");
                Console.WriteLine($"</div>");
            }
        }
    }
}
