using System;
using System.Linq;
using System.Collections.Generic;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > line.Count - 1)
                    {
                        startIndex = line.Count - 1;
                    }
                    if (endIndex > line.Count - 1)
                    {
                        endIndex = line.Count - 1;
                    }
                    List<int> indexses = new List<int>();
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        line[startIndex] += line[i + 1];
                        indexses.Add(i + 1);
                    }
                    for (int i = indexses.Count - 1; i >= 0; i--)
                    {
                        if (indexses[i] > line.Count - 1)
                        {
                            break;
                        }
                        line.RemoveAt(indexses[i]);
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partition = int.Parse(command[2]);
                    List<char> substring = line[index].ToList();
                    int listLength = substring.Count;
                    line.RemoveAt(index);

                    for (int i = 0; i < partition; i++)
                    {
                        string element = "";
                        int r = 0;
                        for (r = 0; r < listLength / partition; r++)
                        {
                            element += substring[0];
                            substring.RemoveAt(0);
                            
                        }
                        if ((i + 1) == partition)
                        {
                            if (substring.Count > 0)
                            {
                                for (int z = 0; z < substring.Count; z++)
                                {
                                    element += substring[z];

                                }
                            }
                        }
                        line.Insert(index + i, element);
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}

