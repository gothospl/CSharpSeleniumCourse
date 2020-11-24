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

        public Student(string id, string fname, string lname, int anAge, DateTime dob, string maj, string sId)
            :base(id, fname, lname, anAge, dob)
        {
            major = maj;
            studentId = sId;
        }

        public DateTime GetDOB()
        {
            return base.dateOfBirth;
        }

        public override string HoursOfSleep()
        {
            return "A student gets 5 hours of sleep";
        }
    }
}
