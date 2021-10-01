using Project_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ITBook b = new ITBook
            {
                ID = 1,
                Title = "SQL Server",
                Price = 100.00M,
                Authors = new string[] { "Hunter", "Don Bower" },
                Publisher = "PPPP",
                PublishDate = DateTime.Now,
                Tags = new string[] { "Database", "SQL" },
                Type = BookType.PRINT
            };
            ITBook b1 = new ITBook
            {
                ID = 1,
                Title = "C#",
                Price = 100.00M,
                Authors = new string[] { "J Sharp", "JClark Anderson", "Lisa Roy" },
                Publisher = "PPPP",
                PublishDate = DateTime.Now,
                Tags = new string[] { ".NET", "C#", "Programming" },
                Type = BookType.EBOOK
            };
            AuthorInfoImpl<Book> ai = new AuthorInfoImpl<Book>();
            TagInfoImpl<Book> ti = new TagInfoImpl<Book>();
            Console.WriteLine("Testing Interface behaviour");
            Console.WriteLine("---------------------------");
            Console.WriteLine(b.Detail());
            Console.WriteLine($"Authors\t\t: {ai.GetAuthorNames(b)}");
            Console.WriteLine($"Tags\t\t: {ti.GetTags(b)}");
            Console.WriteLine();
            Console.WriteLine(b1.Detail());
            Console.WriteLine($"Authors\t\t: {ai.GetAuthorNames(b1)}");
            Console.WriteLine($"Tags\t\t: {ti.GetTags(b1)}");
            Console.ReadLine();
        }//Main
    }//Class
}//Namespace
