using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    class HomeLoan : Loan
    {
        private decimal homeLoanAdminFee = 5000;

        public string Address { get; set; }
        public string YearBuilt { get; set; }
        public string SquareFootage { get; set; }

        public HomeLoan(int loanId, string firstName, string lastName, decimal interestRate, decimal loanAmount, int loanDuration, string address, string yearBuilt, string squareFootage)
            : base(loanId, firstName, lastName, interestRate, loanAmount, loanDuration)
        {
            Address = address;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        public override decimal CalculateInterest()
        {
            return (InterestRate / (LoanNumberOfYears * 12M)) * (LoanAmount + homeLoanAdminFee);
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"\nAddress:\t\t{Address}" +
                $"\nYear Built:\t{YearBuilt}" +
                $"\nSquare Footage:\t{SquareFootage}" +
                $"\nInterest:\t\t{CalculateInterest().ToString("C")}";
        }
    }
}
