using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    class Student : Person
    {
        private string major;
        private string studentId;

        public Student(string id, string fname, string lname, int anAge, string maj, string sId)
            :base(id, fname, lname, anAge)
        {
            major = maj;
            studentId = sId;
        }
    }
}
