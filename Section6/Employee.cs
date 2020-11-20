using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Employee
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public int MonthlySalary { get; set; }

        public Employee(int eNumber, string fName, string lName, DateTime hireDate, string jobDesc, string dept, int salary)
        {
            EmployeeNumber = eNumber;
            FirstName = fName;
            LastName = lName;
            DateOfHire = hireDate;
            JobDescription = jobDesc;
            Department = dept;
            MonthlySalary = salary;
        }

        public string FirstNameSpaceLastName(string fName, string lName)
        {
            return $"{fName} {lName}";
        }

        public string LastNameCommaSpaceFirstName(string fName, string lName)
        {
            return $"{lName}, {fName}";
        }
    }
}
