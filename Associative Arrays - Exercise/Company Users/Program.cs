using System;
using System.Collections.Generic;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            string[] companyInfo = Console.ReadLine().Split(" -> ");
            while (companyInfo[0] != "End")
            {
                string companyName = companyInfo[0];
                string employerId = companyInfo[1];
                if (company.ContainsKey(companyName))
                {
                    if (company[companyName].Contains(employerId))
                    {
                       
                    }
                    else
                    {
                        company[companyName].Add(employerId);
                    }
                }
                else
                {
                    company.Add(companyName, new List<string>());
                    company[companyName].Add(employerId);
                }
                
                
                companyInfo = Console.ReadLine().Split(" -> ");
            }
            foreach (var item in company)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"-- {string.Join("\n-- ",item.Value)}");
                
            }
        }
    }
}
