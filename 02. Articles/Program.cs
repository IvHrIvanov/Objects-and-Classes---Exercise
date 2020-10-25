using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] token = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            
            Articles articles = new Articles(token[0], token[1], token[2]);

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] inputComand = Console.ReadLine().Split(": ").ToArray();

                string comand = inputComand[0];
                string argument = inputComand[1];

                switch(comand)
                {
                    case "Edit":
                        articles.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        articles.ChangeAutor(argument);
                        break;
                    case "Rename":
                        articles.Rename(argument);
                        break;
                }

            }

            Console.WriteLine(articles.ToString());

        }
    }

    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; } 
        public string Content { get; set; } 
        public string Author { get; set; } 

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAutor(string newAutor)
        {
            Author = newAutor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
