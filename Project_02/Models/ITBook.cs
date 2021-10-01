using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02.Models
{
    public class ITBook:Book
    {
        public ITBook() : base() { }
        public ITBook(int id, string title, decimal price, BookType type, string[] author, string publisher, DateTime publishdate,string[] tags)
            : base(id, title, price, type, author, publisher, publishdate)
        {
            this.Tags = tags;
        }
        public string[] Tags { get; set; }

        public override string Detail()
        {
            return $"Title\t\t: {Title}\nPublisher\t: {Publisher}\nPublished on\t: {PublishDate:yyyy-MMM-dd}\nPrice\t\t: {Price:0.00}\nType\t\t: {Type}";
        }
    }//Class
}//Namespace
