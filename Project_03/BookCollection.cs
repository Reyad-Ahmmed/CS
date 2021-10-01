using Project_02.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_03
{
    public class BookCollection : IEnumerable<Book>
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book b)
        {
            this.books.Add(b);
        }
        public void AddBook(Book[] b)
        {
            this.books.AddRange(b);
        }
        public void Delete(Book b)
        {
            this.books.Remove(b);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            foreach(var b in books)
            {
                yield return b;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.books.GetEnumerator();
        }
    }//Class
}//Namespace
