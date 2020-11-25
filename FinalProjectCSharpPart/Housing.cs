using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharpPart
{
    class Housing
    {
        public string Address { get; set; }
        public string TypeOfConstruction { get; set; }
        public string YearBuilt { get; set; }

        public Housing(string address, string typeOfConstruction, string yearBuilt)
        {
            Address = address;
            TypeOfConstruction = typeOfConstruction;
            YearBuilt = yearBuilt;
        }

        public virtual decimal ProjectedRentalAmt()
        {
            return 0M;
        }

        public override string ToString()
        {
            return $"Address:\t\t\t{Address}" +
                $"\nTypeOfConstruction:\t{TypeOfConstruction}" +
                $"\nYearBuilt:\t\t{YearBuilt}";
        }
    }
}
