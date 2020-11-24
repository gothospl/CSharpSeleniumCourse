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

        public Person(string id, string fname, string lname, int ageV)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = ageV;
        }


        public override string ToString()
        {
            return $"First Name: {firstName}" +
                $"\nLast Name: {lastName}";
        }
    }
}
