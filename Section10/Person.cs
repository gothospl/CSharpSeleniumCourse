
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    abstract class Person
    {
        private string idNumber;
        private string lastname;
        private string firstname;
        private int age;

        public Person()
        {


        }

        public Person(string id, string lname, string fname, int anAge)
        {
            idNumber = id;
            lastname = lname;
            firstname = fname;
            age = anAge;
        }

        public abstract string GetExcerciseHabits();
    }
}
