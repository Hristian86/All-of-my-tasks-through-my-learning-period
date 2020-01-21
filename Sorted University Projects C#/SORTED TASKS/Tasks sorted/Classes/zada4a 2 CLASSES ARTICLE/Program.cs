using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_CLASSES_ARTICLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] text = Console.ReadLine().Split(", ");

            int numberOfWords = int.Parse(Console.ReadLine());
            List<Article> arengetArt = new List<Article>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string[] command = Console.ReadLine().Split(", ");
                Article art = new Article()
                {
                    Title = command[0],
                    Content = command[1],
                    Author = command[2]
                };
                arengetArt.Add(art);
            }

            string order = Console.ReadLine();

            if (order == "title")
            {
                arengetArt = arengetArt.OrderBy(x => x.Title).ToList();
            }
            else if (order == "content")
            {
                arengetArt = arengetArt.OrderBy(x => x.Content).ToList();
            }
            else if (order == "author")
            {
                arengetArt = arengetArt.OrderBy(x => x.Author).ToList();
            }
            foreach (var article in arengetArt)
            {
                Console.WriteLine(article);
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        //public Article(string title, string content, string author)
        //{
        //    this.Title = title;
        //    this.Content = content;
        //    this.Author = author;
        //}
        public override string ToString()
        {
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    };
}