using System;
using System.Linq;

namespace _11
{
    class Program
    {

        static void FirstLastEvenOrOdd(int[] array, string[] command, int count, string parity)
        {
            int[] resultEven = new int[array.Length];
            int[] resultOdd = new int[array.Length];
            int indexEven = 0;
            int indexOdd = 0;
            int evenCount = 0;
            int oddCount = 0;
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        resultEven[indexEven++] = array[i];
                        evenCount++;
                    }
                    else
                    {
                        resultOdd[indexOdd++] = array[i];
                        oddCount++;
                    }
                }
                int length = 0;
                if (parity == "even")
                {
                    if (evenCount >= count)
                    {
                        length = count;
                    }
                    else
                    {
                        length = evenCount;
                    }
                }
                else if (parity == "odd")
                {

                    if (oddCount >= count)
                    {
                        length = count;
                    }
                    else
                    {
                        length = oddCount;
                    }
                }
                int[] finalResultEven = new int[length];
                int[] finalResultOdd = new int[length];
                if (command[0] == "first")
                {
                    if (parity == "even")
                    {
                        Console.Write($"[");
                        if (evenCount == 0)
                        {
                            Console.WriteLine($"]"); ;
                        }
                        else
                        {
                            for (int i = 0; i < evenCount; i++)
                            {
                                if (i == count)
                                {
                                    break;
                                }
                                finalResultEven[i] = resultEven[i];
                            }
                            Console.Write(string.Join(", ", finalResultEven));
                            Console.WriteLine($"]");
                        }
                    }
                    else if (parity == "odd")
                    {
                        Console.Write($"[");
                        if (oddCount == 0)
                        {
                            Console.WriteLine($"]"); ;
                        }
                        else
                        {
                            for (int i = 0; i < oddCount; i++)
                            {
                                if (i == count)
                                {
                                    break;
                                }
                                finalResultOdd[i] = resultOdd[i];
                            }
                            Console.Write(string.Join(", ", finalResultOdd));
                            Console.WriteLine($"]");
                        }
                    }
                }
                else if (command[0] == "last")
                {
                    if (parity == "even")
                    {
                        int index = 0;
                        Console.Write($"[");
                        if (evenCount == 0)
                        {
                            Console.WriteLine($"]");
                        }
                        else
                        {
                            for (int i = resultEven.Length - count; i < resultEven.Length; i++)
                            {
                                if (index > evenCount)
                                {
                                    break;
                                }
                                finalResultEven[index++] = resultEven[i];
                            }
                            Console.Write(string.Join(", ", finalResultEven));
                            Console.WriteLine($"]");
                        }
                    }
                    else if (parity == "odd")
                    {
                        int index = 0;
                        Console.Write($"[");
                        if (oddCount == 0)
                        {
                            Console.WriteLine($"]");
                        }
                        else
                        {
                            for (int i = resultOdd.Length - count; i < resultOdd.Length; i++)
                            {
                                if (index + 1 > oddCount)
                                {
                                    break;
                                }
                                finalResultOdd[index++] = resultOdd[i];
                            }
                            Console.Write(string.Join(", ", finalResultOdd));
                            Console.WriteLine($"]");
                        }
                    }
                }
            }
        }

        static void MaxMinEvenOrOdd(int[] array, string[] command, string parity)
        {

            int maxEvenIndex = -1;
            int maxEven = int.MinValue;
            int maxOddIndex = -1;
            int maxOdd = int.MinValue;
            int minEvenIndex = -1;
            int minEven = int.MaxValue;
            int minOddIndex = -1;
            int minOdd = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (maxEven <= array[i])
                    {
                        if (maxEvenIndex < i)
                        {
                            maxEven = array[i];
                            maxEvenIndex = i;
                        }
                    }
                    if (minEven >= array[i])
                    {
                        if (minEvenIndex < i)
                        {
                            minEven = array[i];
                            minEvenIndex = i;
                        }
                    }
                }
                else
                {
                    if (maxOdd <= array[i])
                    {
                        if (maxOddIndex < i)
                        {
                            maxOdd = array[i];
                            maxOddIndex = i;

                        }
                    }
                    if (minOdd >= array[i])
                    {
                        if (minOddIndex < i)
                        {
                            minOdd = array[i];
                            minOddIndex = i;
                        }
                    }
                }
            }
            if (command[0] == "max")
            {
                if (parity == "even")
                {
                    if (maxEvenIndex > -1)
                    {
                        Console.WriteLine(maxEvenIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (parity == "odd")
                {
                    if (maxOddIndex > -1)
                    {
                        Console.WriteLine(maxOddIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
            }
            else if (command[0] == "min")
            {
                if (parity == "even")
                {
                    if (minEvenIndex > -1)
                    {
                        Console.WriteLine(minEvenIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (parity == "odd")
                {
                    if (minOddIndex > -1)
                    {
                        Console.WriteLine(minOddIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
            }



        }
        static int[] Exchange(int[] array, int index)
        {
            int[] result = new int[array.Length];
            if (index >= 0 && index < array.Length)
            {
                int startIndex = 0;
                for (int i = index + 1; i < array.Length; i++)
                {
                    result[startIndex++] = array[i];
                }

                for (int i = 0; i <= index; i++)
                {
                    result[startIndex++] = array[i];
                }
                array = result;

            }
            else
            {
                Console.WriteLine($"Invalid index");
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    array = Exchange(array, index);
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    if (command[1] == "even" || command[1] == "odd")
                    {
                        string parity = command[1];
                        MaxMinEvenOrOdd(array, command, parity);
                    }
                }
                else if (command[0] == "first" || command[0] == "last")
                {
                    if (command[2] == "even" || command[2] == "odd")
                    {
                        int count = int.Parse(command[1]);
                        string parity = command[2];
                        FirstLastEvenOrOdd(array, command, count, parity);
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.Write($"[");
            Console.Write(string.Join(", ", array));
            Console.WriteLine($"]");
        }
    }
}
