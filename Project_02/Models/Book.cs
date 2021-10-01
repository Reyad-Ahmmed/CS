using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02.Models
{
    public enum BookType { PRINT, EBOOK }
    public abstract class Book
    {
        public Book() { }
        public Book(int id,string title,decimal price,BookType type,string[] author,string publisher,DateTime publishdate)
        {
            this.ID = id;
            this.Title = title;
            this.Price = price;
            this.Authors = author;
            this.Publisher = publisher;
            this.PublishDate = publishdate;
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public BookType Type { get; set; }
        public string[] Authors { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public abstract string Detail();
        
    }//Class
}//Namespace
