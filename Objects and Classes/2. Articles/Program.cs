using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article (string title,string content,string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
       
        
        public void Edit(string content)
        {
            this.Content=content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author=author; 
        }
        public void Rename(string title)
        {
           this.Title=title;
        }
        public void Print()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }
//•	Edit(new content) – change the old content with the new one
//•	ChangeAuthor(new author) – change the author
//•	Rename(new title) – change the title of the article
//•	Override the ToString method – print the article in the following format: 
//"{title} - {content}: {author}"


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
            List<string> list = Console.ReadLine().Split(", ").ToList();
           Article myArticle =  new Article(list[0],list[1],list[2]);
                myArticle.Print();

            }
            string type = Console.ReadLine();
            
        }
    }
}
