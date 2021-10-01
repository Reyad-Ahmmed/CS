using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02.Models
{
    public class AuthorInfoImpl<T> : IAuthorInfo<T> where T : Book
    {
        public string GetAuthorNames(T book)
        {
            if(book is ITBook)
            {
                ITBook b = book as ITBook;
                return string.Join(", ", b.Authors);
            }
            else
            {
                throw new Exception("Unknown  type");
            }
        }
    }//Class
}//Namespace
