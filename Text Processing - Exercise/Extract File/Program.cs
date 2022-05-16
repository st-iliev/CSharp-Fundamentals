using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split("\\");
            string fileName = "";
            string fileExtension = "";

            foreach (var item in filePath)
            {
                if (item.Contains('.'))
                {
                 fileName = item.Split(".")[0];
                 fileExtension = item.Split(".")[1];
                  break;
                }
            }
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
