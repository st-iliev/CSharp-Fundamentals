using System;

namespace Basic_Syntax___More_Exercise_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {  
            int max = int.MinValue;
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            for (int i = 1; i <= 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= max)
                {
                    if (max >= max1)
                    {
                        if (max1 >= max2)
                        {
                            max2 = max1;
                        }
                        max1 = max;
                    }
                    max = n;
                }
                else if (n < max)
                {
                    if (n >= max1)
                    {
                        if(max1 >= max2)
                        {
                            max2 = max1;
                        }    
                        max1 = n;
                    }
                    else
                    {
                        max2 = n;
                    }

                }
            }
            Console.WriteLine(max);
            Console.WriteLine(max1);
            Console.WriteLine(max2);
        }
    }
}
