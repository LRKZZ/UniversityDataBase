using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    public class Laws
    {
        public string prefix;
        public string number;
        public string nameoflaw;
        public string content;
        public Laws(string prefix, string number, string nameoflaw, string content)
        {
            this.prefix = prefix;
            this.number = number;
            this.nameoflaw = nameoflaw;
            this.content = content;
        }
    }
}
