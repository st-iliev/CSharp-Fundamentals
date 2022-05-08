﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string resourse = Console.ReadLine();
            while (resourse != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resourses.ContainsKey(resourse))
                {
                    resourses.Add(resourse, 0);
                }
                resourses[resourse] += quantity;
                resourse = Console.ReadLine();
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
