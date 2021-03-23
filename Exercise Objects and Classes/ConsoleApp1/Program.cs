using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ").ToArray();
                var article = new Article(input[0], input[1], input[2]);
                list.Add(article);
            }
            string comm = Console.ReadLine();
            List<Article> sortedArticle = new List<Article>();
            if (comm == "title")
            {
                sortedArticle = list.OrderBy(x => x.Title).ToList();
            }
            else if (comm == "content")
            {
                sortedArticle = list.OrderBy(x => x.Content).ToList();
            }
            else if (comm == "author")
            {
                sortedArticle = list.OrderBy(x => x.Author).ToList();
            }
            foreach (var item in sortedArticle)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    class Article 
    {
        public Article(string title,string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent) 
        {
            Content = newContent;
        }
        public void ChangeAutor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string rename)
        {
            Title = rename;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
