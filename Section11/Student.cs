using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    class Student : Person, ITraveler
    {
        private string major;
        private string studentId;

        public Student(string id, string fname, string lname, int anAge, string maj, string sId)
            :base(id, fname, lname, anAge)
        {
            major = maj;
            studentId = sId;
        }

        public double DetermineMiles()
        {
            return 75.0;
        }

        public string GetDestination()
        {
            return "Home";
        }

        public string GetStartLocation()
        {
            return "School";
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n Destination: {GetDestination()}" +
                $"\n Start Loaction: {GetStartLocation()}" +
                $"\n Miles: {DetermineMiles()}";
        }
    }
}
