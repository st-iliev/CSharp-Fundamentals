using System;
using System.Linq;
using System.Collections.Generic;


namespace _3
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Author = author;
            this.Content = content;
            this.Title = title;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return this.Title + "-" + this.Content + ":" + this.Author;
        }
    }
    class Articles
    {
        public Articles()
        {
            this.article = new List<Article>();
        }
        public List<Article> article { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Articles allArticles = new Articles();
            int numbersOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersOfArticles; i++)
            {
                string[] articles = Console.ReadLine().Split(", ");
                string title = articles[0];
                string content = articles[1];
                string author = articles[2];
                Article newArticle = new Article(title, content, author);
                allArticles.article.Add(newArticle);
            }
            string criteria = Console.ReadLine();
            List<Article> sortedArticles = new List<Article>();
            if (criteria == "title")
            {
            sortedArticles = allArticles.article.OrderBy(s => s.Title).ToList();              
            }
            else if (criteria == "content")
            {
                sortedArticles = allArticles.article.OrderBy(s => s.Content).ToList();
            }
            else
            {
                sortedArticles = allArticles.article.OrderBy(s => s.Author).ToList();
            }
            foreach (Article item in sortedArticles)
            {
                Console.WriteLine($"{item.Title} - { item.Content}: { item.Author}");
            }
        }
    }
}

