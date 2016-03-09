using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.models
{
    public class HtmlControlEntity
    {
        public string Title { get; set; }
        public HashSet<HtmlElement> Names { get; set; }
    }
}
