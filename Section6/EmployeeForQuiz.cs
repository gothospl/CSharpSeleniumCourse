using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class EmployeeForQuiz
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfHire { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public int MonthlySalary { get; set; }

        public EmployeeForQuiz(int eNumber, string fName, string lName, string hireDate, string jobDesc, string dept, int salary)
        {
            EmployeeNumber = eNumber;
            FirstName = fName;
            LastName = lName;
            DateOfHire = hireDate;
            JobDescription = jobDesc;
            Department = dept;
            MonthlySalary = salary;
        }

        public string FirstNameSpaceLastName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public string LastNameCommaSpaceFirstName()
        {
            return $"{this.LastName}, {this.FirstName}";
        }
    }
}
