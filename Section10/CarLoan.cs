using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    class CarLoan : Loan
    {
        private decimal carLoanAdminFee = 1000;

        public string YearBuilt { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }

        public CarLoan(int loanId, string firstName, string lastName, decimal interestRate, decimal loanAmount, int loanDuration, string yearBuilt, string model, string make, string color)
            : base(loanId, firstName, lastName, interestRate, loanAmount, loanDuration)
        {
            YearBuilt = yearBuilt;
            Model = model;
            Make = make;
            Color = color;
        }

        public override decimal CalculateInterest()
        {
            return (InterestRate / (LoanNumberOfYears * 12M)) * (LoanAmount + carLoanAdminFee);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nYear Built:\t{YearBuilt}" +
                $"\nModel:\t\t{Model}" +
                $"\nMake:\t\t{Make}" +
                $"\nColor:\t\t{Color}" +
                $"\nInterest:\t\t{CalculateInterest().ToString("C")}";
        }
    }
}
