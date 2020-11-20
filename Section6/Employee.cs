﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Employee
    {
        //Constructors
        public Employee(int id)
        {
            EmployeeID = id;
        }

        public Employee(string name, int id, string title)
        {
            Name = name;
            EmployeeID = id;
            JobTitle = title;
        }

        //Properties
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        //Methods
        public string JobLocation()
        {
            if (JobTitle == "Manager")
            {
                return "Boston";
            }
            else if (JobTitle == "Staff")
            {
                return "Chicago";
            }

            return "New York";
        }

        public override string ToString()
        {
            return $"{EmployeeID} {Name} Job Title: {JobTitle}";
        }
    }
}
