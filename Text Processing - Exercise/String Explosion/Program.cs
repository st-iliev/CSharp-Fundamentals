using System;
using System.Text;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder explosion = new StringBuilder();
            string line = Console.ReadLine();
            int count = 0;
            int savedPower = 0;
            for (int i = 0; i < line.Length; i += 1 + count)
            {
                if (line[i] == '>')
                {
                    count = 0;
                    explosion.Append(line[i]);
                    int explosionPower = int.Parse(line[i + 1].ToString());
                    int explosionRange = i + explosionPower + savedPower;
                    for (int r = i + 1; r <= explosionRange; r++)
                    {
                        if (r == line.Length)
                        {
                            break;
                        }
                        if (line[r] != '>')
                        {
                            explosionPower--;
                            count++;

                        }
                        else if (line[r] == '>')
                        {
                            savedPower += explosionPower;
                            break;
                        }
                    }
                    explosionPower = savedPower;
                }
                else if (line[i] != '>')
                {
                    count = 0;
                    explosion.Append(line[i]);
                }
            }
            Console.WriteLine(explosion);
        }
    }
}
