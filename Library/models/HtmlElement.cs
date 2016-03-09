using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.models
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string HtmlCode { get; set; }

        public HtmlElement()
        {

        }
        public HtmlElement(string name, string htmlCode)
        {
            this.Name = name;
            this.HtmlCode = htmlCode;
        }
    }
}
