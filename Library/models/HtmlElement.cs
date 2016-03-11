using Devsoft.Net.HttpClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.models
{
    public class HtmlElement
    {
        private string htmlCode;
        public string Name { get; set; }

        public string HtmlCode
        {
            get
            {
                if (htmlCode == null)
                    htmlCode = readFromFile();
                return htmlCode;
            }
            set
            {
                htmlCode = value;
            }
        }

        public HtmlElement()
        {

        }
        public HtmlElement(string name, string htmlCode)
        {
            this.Name = name;
            this.HtmlCode = htmlCode;
        }

        public void saveToFile()
        {
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(this.HtmlCode);
            document.Save(this.Name + Constant.EXTENSION);
        }

        public string readFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(this.Name + Constant.EXTENSION))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                return null;
            }
        }
    }
}
