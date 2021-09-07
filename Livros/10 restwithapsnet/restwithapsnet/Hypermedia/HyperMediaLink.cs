using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restwithapsnet.Hypermedia
{
    public class HyperMediaLink
    {
        public string Real { get; set; }
        public string Href
        {
            get
            {
                object _look = new object();
                lock (_look)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("%2F", "/").ToString();
                }
            }
            set
            {
                href = value;
            }
        }


        private string href; // Atributo para manipualr a // no endereço 
        public string Type { get; set; }
        public string Action { get; set; }
    }
}
