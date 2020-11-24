using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11
{
    abstract class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public Person(string id, string lname, string fname, int ageV)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = ageV;
        }
    }
}
