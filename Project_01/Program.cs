using Project_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ITBook[] books = new ITBook[] {
                new ITBook(1, "Programming C#", 990.00M, BookType.PRINT, "Wrox Inc.", new DateTime(2019, 7, 3)),
                new ITBook(2, "Programming Python", 990.00M, BookType.EBOOK, "Wrox Inc.", new DateTime(2019, 7, 3)),
                new ITBook(3, "HTML5 CSS3", 990.00M, BookType.PRINT, "MPress", new DateTime(2019, 7, 3)),
                new ITBook(4, "SQL Server 2017", 990.00M, BookType.PRINT, "Wrox Inc.", new DateTime(2019, 7, 3))
            };
            books[0].AddAuthors(new string[] { "John Sharp", "Dean Ambross" });
            books[0].AddTags(new string[] { "Programming", ".Net", "C#" });
            books[1].AddAuthors(new string[] { "Blitz Sara" });
            books[1].AddTags(new string[] { "Programming", "Python" });
            books[2].AddAuthors(new string[] { "K Joe" });
            books[2].AddTags(new string[] { "Programming", "Web development", "Web" });
            Console.WriteLine("Book List");
            Console.WriteLine("===========================================");
            foreach (var b in books)
            {
                Console.WriteLine(b);
                Console.WriteLine();
            }
            Array.Sort(books); //IT book is comaparable so sorting will work
            Console.WriteLine("Book List (sorted ascending on title)");
            Console.WriteLine("===========================================");
            foreach (var b in books)
            {
                Console.WriteLine(b);
                Console.WriteLine();
            }
            Array.Reverse(books);
            Console.WriteLine("Book List (sorted descending on title)");
            Console.WriteLine("===========================================");
            foreach (var b in books)
            {
                Console.WriteLine(b);
                Console.WriteLine();
            }
            Console.WriteLine("Linq queries");
            Console.WriteLine("===========================================");
            Console.WriteLine("Ordering");
            Console.WriteLine("===========================================");
            var q1 =
                books
                .OrderBy(x => x.Price);
            foreach (var b in q1)
            {
                Console.WriteLine(b);
                Console.WriteLine();
            }
            Console.WriteLine("Filtering (only PRINT Book");
            Console.WriteLine("===========================================");
            var q2 = from x in books
                     where x.Type == BookType.PRINT
                     select x;

            foreach (var b in q2)
            {
                Console.WriteLine(b);
                Console.WriteLine();
            }
            Console.WriteLine("Grouping by type");
            Console.WriteLine("===========================================");
            var q3 = books
                .GroupBy(x => x.Type);
            foreach (var g in q3)
            {
                Console.WriteLine(g.Key);
                foreach (var b in g)
                {
                    Console.WriteLine($"{b}");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
