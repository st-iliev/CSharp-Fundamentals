using System;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string message = Console.ReadLine();
            while (message!= "find")
            {
                int count = 0;
                string decryptMessage = "";
                for (int i = 0; i < message.Length; i++)
                {
                    if (count > key.Length-1)
                    {
                        count = 0;
                    }
                    decryptMessage += (char)(char.Parse(message[i].ToString()) - key[count++]);
                }
                string treasureType = "";
                string coordinate = "";
                int startTreasureIndex = -1;
                int endTrasureIndex = -1;
                int startCoordinateIndex = -1;
                for (int i = 0; i < decryptMessage.Length; i++)
                {
                    if (decryptMessage[i] == '&')
                    {
                        if (startTreasureIndex == -1)
                        {
                            startTreasureIndex = i+1;
                        }
                        else
                        {
                            endTrasureIndex = i;
                        }
                    }
                    else if (decryptMessage[i] == '<')
                    {
                        startCoordinateIndex = i+1;
                    } 
                }
                treasureType = decryptMessage.Substring(startTreasureIndex, endTrasureIndex-startTreasureIndex);
                coordinate = decryptMessage.Substring(startCoordinateIndex, decryptMessage.Length-1-startCoordinateIndex);
                Console.WriteLine($"Found {treasureType} at {coordinate} ");
                message = Console.ReadLine();
            }
        }
    }
}
