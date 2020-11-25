using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharpPart
{
    class MultiUnit : Housing, IUnits
    {
        public string ComplexName { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal RentAmountPerUnit { get; set; }

        public MultiUnit(string address, string typeOfConstruction, string yearBuilt, string complexName, int numberOfUnits, decimal rentAmountPerUnit)
            :base(address, typeOfConstruction, yearBuilt)
        {
            ComplexName = complexName;
            NumberOfUnits = numberOfUnits;
            RentAmountPerUnit = rentAmountPerUnit;
        }

        public override decimal ProjectedRentalAmt()
        {
            return RentAmountPerUnit * GetNumUnits() * 12M;
        }

        public int GetNumUnits()
        {
            return NumberOfUnits;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nComplex Name:\t\t{ComplexName}" +
                $"\nNumber Of Units:\t{NumberOfUnits.ToString()}" +
                $"\nRent Amount Per Unit:\t{RentAmountPerUnit.ToString("C")}" +
                $"\nProjected Rental Amount:\t{ProjectedRentalAmt().ToString("C")}" +
                $"\n";
        }
    }
}
