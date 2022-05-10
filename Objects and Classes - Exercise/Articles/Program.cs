using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Author = author;
            this.Content = content;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void EditContent(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void RenameTitle(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ");
            string title = article[0];
            string content = article[1];
            string author = article[2];
            var articleInfo = new Article(title, content, author);
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ");     
                if (command[0] == "Edit")
                {
                    string newContent = command[1];
                    articleInfo.EditContent(newContent);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    articleInfo.ChangeAuthor(newAuthor);
                }
                else if (command[0] == "Rename")
                {
                    string newTitle = command[1];
                    articleInfo.RenameTitle(newTitle);
                }
            }
            Console.WriteLine(articleInfo.ToString());
        }
    }
}
