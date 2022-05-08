using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); 
            int[] ladyBugsInField = new int[fieldSize]; 
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

            foreach (var initialIndex in initialIndexes) 
            {
                if (initialIndex >= 0 && initialIndex < fieldSize)
                {
                    ladyBugsInField[initialIndex] = 1;
                }
            }

            string command = string.Empty; 
            while ((command = Console.ReadLine()) != "end") 
            {
                int start = int.Parse(command.Split()[0]); 
                int moveStep = int.Parse(command.Split()[2]); 
                string direction = command.Split()[1]; 

                if (start >= 0 && start < fieldSize) 
                {
                    if (ladyBugsInField[start] == 0 || moveStep == 0) 
                    {
                        continue;
                    }
                    else
                    {
                        ladyBugsInField[start] = 0;

                        if (direction == "left") 
                        {
                            if (start - moveStep >= 0 && start - moveStep < fieldSize) 
                            {
                                for (int i = start - moveStep; i < fieldSize && i >= 0; i -= moveStep) 
                                {
                                    if (ladyBugsInField[i] == 0) 
                                    {
                                        ladyBugsInField[i] = 1; 
                                        break; 
                                    }
                                }
                            }
                        }
                        else if (direction == "right") 
                        {
                            if (start + moveStep >= 0 && start + moveStep < fieldSize) 
                            {
                                for (int i = start + moveStep; i < fieldSize && i >= 0; i += moveStep) 
                                {
                                    if (ladyBugsInField[i] == 0) 
                                    {
                                        ladyBugsInField[i] = 1; 
                                        break; 
                                    }
                                }
                            }
                        }
                        else 
                        {
                            ladyBugsInField[start] = 1; 
                            continue;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", ladyBugsInField)); 
        }
    }
}