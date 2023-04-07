using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    public class BossOfThisUniversity
    {
        public string name;
        public string rank;
        List<Laws> laws;
        public BossOfThisUniversity(string name, string rank, List<Laws> laws)
        {
            this.name = name;
            this.rank = rank;
            this.laws = laws;
        }
    }
}
