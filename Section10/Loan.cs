using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    abstract class Loan
    {
        public int LoanNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public decimal InterestRate { get; set; }
        public decimal LoanAmount { get; set; }
        public int LoanNumberOfYears { get; set; }

        public Loan(int loanId, string firstName, string lastName, decimal interestRate, decimal loanAmount, int loanDuration)
        {
            LoanNumber = loanId;
            CustomerFirstName = firstName;
            CustomerLastName = lastName;
            InterestRate = interestRate;
            LoanAmount = loanAmount;
            LoanNumberOfYears = loanDuration;
        }

        public abstract decimal CalculateInterest();

        public override string ToString()
        {
            return $"Loan number:\t{LoanNumber}" +
                $"\nClient:\t\t{CustomerFirstName} {CustomerLastName}" +
                $"\nInterest Rate:\t{InterestRate.ToString("P")}" +
                $"\nLoan Amount:\t{LoanAmount.ToString("C")}" +
                $"\nLoan Duration:\t{LoanNumberOfYears} years";
        }
    }
}
