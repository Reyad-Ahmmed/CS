using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public enum BookType { PRINT, EBOOK}
    public abstract class Book:IAuthor
    {
        public Book() {
            this.Authors = new List<string>();
        }
        public Book(int id, string title, decimal price, BookType type, string publisher, DateTime publishDate)
        {
            this.ID = id;this.Title = title;this.Price = price;this.Type = type;this.Publisher = publisher;
             this.PublishDate = publishDate;
            this.Authors = new List<string>();
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public BookType Type { get; set; }
        public List<string> Authors { get; private set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }

        public string AuthorList {
            get
            {
                return string.Join(", ", this.Authors.ToArray());
            }
        }

        public void AddAuthor(string author)
        {
            this.Authors.Add(author);
        }

        public void AddAuthors(IEnumerable<string> authors)
        {
            this.Authors.AddRange(authors);
        }
    }
}
