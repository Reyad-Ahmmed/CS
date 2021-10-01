using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public interface IAuthor
    {
        void AddAuthor(string author);
        void AddAuthors(IEnumerable<string> authors);
        string AuthorList { get; }
    }
}
