using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>(num);
            List<string> guest = new List<string>();
            for (int i = 0; i < num; i++)
            {
                guest = Console.ReadLine().Split().ToList();
                if (guest[2] == "going!")
                {
                    bool isFind = false;
                    for (int r = 0; r < guestList.Count; r++)
                    {
                        if (guest[0] == guestList[r])
                        {
                            Console.WriteLine($"{guest[0]} is already in the list!");
                            isFind = true;
                        }

                    }
                    if (!isFind)
                    {
                        guestList.Add(guest[0]);
                    }
                }
                else if (guest[2] == "not")
                {
                    bool notFind = true;
                    for (int r = 0; r < guestList.Count; r++)
                    {
                        if (guest[0] == guestList[r])
                        {
                            guestList.RemoveAt(r);
                            notFind = false;
                            break;
                        }
                    }
                    if (notFind)
                    {
                        Console.WriteLine($"{guest[0]} is not in the list!");
                    }
                }

            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
