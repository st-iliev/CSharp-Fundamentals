using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morsecode = new Dictionary<string, char>();
            morsecode.Add(".-", 'A'); morsecode.Add("-...", 'B'); morsecode.Add("-.-.", 'C');
            morsecode.Add("-..", 'D'); morsecode.Add(".", 'E'); morsecode.Add("..-.", 'F');
            morsecode.Add("--.", 'G'); morsecode.Add("....", 'H'); morsecode.Add("..", 'I');
            morsecode.Add(".---", 'J'); morsecode.Add("-.-", 'K'); morsecode.Add(".-..", 'L');
            morsecode.Add("--", 'M'); morsecode.Add("-.", 'N'); morsecode.Add("---", 'O');
            morsecode.Add(".--.", 'P'); morsecode.Add("--.-", 'Q'); morsecode.Add(".-.", 'R');
            morsecode.Add("...", 'S'); morsecode.Add("-", 'T'); morsecode.Add("..-", 'U');
            morsecode.Add("...-", 'V'); morsecode.Add(".--", 'W'); morsecode.Add("-..-", 'X');
            morsecode.Add("-.--", 'Y'); morsecode.Add("--..", 'Z');
            StringBuilder result = new StringBuilder();
            string[] translate = Console.ReadLine().Split("|");
            List<string> pieces = new List<string>();
            List<string> pieceOfTranslate = new List<string>();
            for (int i = 0; i < translate.Length; i++)
            {
                string piece = translate[i].ToString();
                string word = "";
                for (int z = 0; z < piece.Length; z++)
                {           
                    if (piece[z] != ' ')
                    {
                        word += piece[z];
                        if (z == piece.Length - 1)
                        {
                            result.Append(morsecode[word]);
                        }
                    }
                    else
                    {
                        if (morsecode.ContainsKey(word))
                        {
                        result.Append(morsecode[word]);
                        }
                        word = "";
                    }
                }
                result.Append(" ");
            }
            Console.WriteLine(result);
        }
    }
}
