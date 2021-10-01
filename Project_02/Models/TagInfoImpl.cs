using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02.Models
{
    public class TagInfoImpl<T> : ITagInfo<T> where T : Book
    {
        public string GetTags(T book)
        {

            if (book is ITBook)
            {
                ITBook b = book as ITBook;
                return string.Join(", ", b.Tags);
            }
            else
            {
                throw new Exception("Unknown  type");
            }
        }
    }
}
