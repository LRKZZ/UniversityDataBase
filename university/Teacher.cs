using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    public class Teacher
    {
        public string name;
        public string department;
        public List<string> departmentlist;
        public Teacher(string name, string department, List<string> departmentlist)
        {
            this.name = name;
            this.department = department;
            this.departmentlist = departmentlist;
        }
    }
}
