using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string patternDemonTotalHealth = @"[^0-9\+\-\*\.\/ ]";
            string patternDemonBaseDamage = @"[-|+]*[0-9]+([.][0-9]+)*";
            string patternMultiDiv = @"[*|\/]+";
            string patternSplit = @"[,\s]+";
            string[] demonBook = Regex.Split(line, patternSplit).OrderBy(s => s).ToArray();
            for (int i = 0; i < demonBook.Length; i++)
            {
                string currentDemon = demonBook[i];
                MatchCollection health = Regex.Matches(currentDemon, patternDemonTotalHealth);
                int demonHealth = 0;
                int demonTotalHealth = 0;
                if (health.Count > 0)
                {
                    foreach (Match item in health)
                    {
                        demonHealth = char.Parse(item.ToString());
                        demonTotalHealth +=demonHealth;
                    }

                }
                MatchCollection damage = Regex.Matches(currentDemon, patternDemonBaseDamage);
                double demonDamage = 0;
                double demonBaseDamage = 0;
                if (damage.Count > 0)
                {
                    
                    foreach (Match item in damage)
                    {
                        demonDamage = double.Parse(item.ToString());
                        demonBaseDamage += demonDamage;                   
                    }  
                }
                MatchCollection matchSymbols = Regex.Matches(currentDemon, patternMultiDiv);
                if (matchSymbols.Count > 0)
                {
                    string symbols = "";
                    foreach (Match item in matchSymbols)
                    {
                        symbols += item;                     
                    }
                    foreach (var item in symbols)
                    {
                        if (item == '*')
                        {
                            demonBaseDamage *= 2;
                        }
                        else if (item == '/')
                        {
                            demonBaseDamage /= 2;
                        }
                    }
                }
                Console.WriteLine($"{currentDemon} - {demonTotalHealth} health, {demonBaseDamage:F2} damage");
            }

        }
    }
}
