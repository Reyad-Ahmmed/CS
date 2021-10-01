using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01.Models
{
    public interface ITags
    {
        void AddTag(string Tag);
        void AddTags(IEnumerable<string> tags);
        string TagList { get; }
    }
}
