using Project_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ITBook b1 = new ITBook
            {
                ID = 1,
                Title = "C#",
                Price = 550.00M,
                Authors = new string[] { "John", "Sharp" },
                Publisher = "MPres Inc",
                PublishDate = DateTime.Now,
                Tags = new string[] { "Towhid", "Asad" },
                Type = BookType.PRINT
            };

            ITBook b2 = new ITBook
            {
                ID = 1,
                Title = "SQL Server",
                Price = 500.00M,
                Authors = new string[] { "Jowel", "Murach's" },
                Publisher = "PPPP",
                PublishDate = DateTime.Now,
                Tags = new string[] { "T", "A" },
                Type = BookType.PRINT
            };
            ITBook b3 = new ITBook
            {
                ID = 3,
                Title = "HTML",
                Price = 700.00M,
                Authors = new string[] { "Mina", "Azim" },
                Publisher = "MPres Inc",
                PublishDate = DateTime.Now,
                Tags = new string[] { "Towhid", "Asad" },
                Type = BookType.PRINT
            };

            ITBook b4 = new ITBook
            {
                ID = 4,
                Title = "CSS",
                Price = 650.00M,
                Authors = new string[] { "H", "D" },
                Publisher = "PPPP",
                PublishDate = DateTime.Now,
                Tags = new string[] { "T", "A" },
                Type = BookType.PRINT
            };
            BookCollection books = new BookCollection();
            //Check Add method
            books.AddBook(b1);
            books.AddBook(b2);
            //check overload
            books.AddBook(new Book[] { b3, b4 });

            Console.WriteLine("Testing Collection : \n");
            foreach (var x in books)
            {
                Console.WriteLine($"{x.Title}\t{x.Type}\t@ {x.Price:0.00}");
                Console.WriteLine();
            }
            //Check delete
            books.Delete(b2);
            Console.WriteLine();
            Console.WriteLine("After Delete : \n");
            foreach (var x in books)
            {
                Console.WriteLine($"{x.Title}\t{x.Type}\t@ {x.Price:0.00}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
