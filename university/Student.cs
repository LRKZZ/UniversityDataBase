using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    public class Student 
    {
        public string group;
        public string name;

        Dictionary<string, int> grade;
        public Student(string group, string name,  Dictionary<string, int> grade)
        {
            this.group = group;
            this.name = name;
            this.grade = grade;
        }
        public Dictionary<string, int> Grade()
        {
            return grade;
        }
    }
}
