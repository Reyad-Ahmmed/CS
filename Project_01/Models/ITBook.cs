using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public sealed class ITBook : Book, ITags, IComparable<Book>
    {
        public ITBook() : base(){
            this.Tags = new List<string>();
        }
        public ITBook(int id, string title, decimal price, BookType type, string publisher, DateTime publishDate) : base(id, title, price, type, publisher, publishDate)
        {
            this.Tags = new List<string>();
        }
        public string BrefDescription { get; set; }
        public List<string> Tags { get; private set; }

        public string TagList => string.Join(",",this.Tags.ToArray());

        public void AddTag(string tag)
        {
            this.Tags.Add(tag);
        }

        public void AddTags(IEnumerable<string> tags)
        {
            this.Tags.AddRange(tags);
        }

        public int CompareTo(ITBook other)
        {
            return this.Title.CompareTo(other.Title);
        }

        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"\t{this.Title} published by {this.Publisher} @ {this.Price}\r\n\tAuthors : {this.AuthorList}\n\tTags: {this.TagList}";
        }
    }
}
