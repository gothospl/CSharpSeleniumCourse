﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    class Person
    {
        private string idNumber;
        private string lastname;
        private string firstname;
        private int age;
        protected DateTime dateOfBirth;

        public Person()
        {


        }

        public Person(string id, string lname, string fname, int anAge, DateTime dob)
        {
            idNumber = id;
            lastname = lname;
            firstname = fname;
            age = anAge;
            dateOfBirth = dob;
        }

        //public abstract string GetExcerciseHabits();
        public virtual string HoursOfSleep()
        {
            return "A person gets 8 hours of sleep.";
        }
    }
}
