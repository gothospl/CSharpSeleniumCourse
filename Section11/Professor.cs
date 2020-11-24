using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    class Professor : Person, ITraveler
    {
        private string empId;
        private string subject;

        public Professor(string id, string fname, string lname, int anAge, string empId, string subject)
            : base(id, fname, lname, anAge)
        {
            EmployeeID = empId;
            SubjectArea = subject;
        }

        public string EmployeeID { get; set; }
        public string SubjectArea { get; set; }

        public double DetermineMiles()
        {
            return 100.0;
        }

        public string GetDestination()
        {
            return "Beach";
        }

        public string GetStartLocation()
        {
            return "Home";
        }
    }
}
