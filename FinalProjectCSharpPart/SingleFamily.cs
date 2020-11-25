using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCSharpPart
{
    class SingleFamily : Housing
    {
        public decimal RentAmount { get; set; }
        public string Size { get; set; }
        public int NumberOfBedrooms { get; set; }
        public string Porch { get; set; }
        public string Garage { get; set; }

        public SingleFamily(string address, string typeOfConstruction, string yearBuilt, decimal rentAmount, string size, int numberOfBedrooms, string porch, string garage)
            :base(address, typeOfConstruction, yearBuilt)
        {
            RentAmount = rentAmount;
            Size = size;
            NumberOfBedrooms = numberOfBedrooms;
            Porch = porch;
            Garage = garage;
        }

        public override decimal ProjectedRentalAmt()
        {
            return RentAmount * 12M;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nRent Amount:\t\t{RentAmount.ToString("C")}" +
                $"\nSize:\t\t\t{Size} sq feet" +
                $"\nNumber of Bedrooms:\t{NumberOfBedrooms.ToString()}" +
                $"\nPorch:\t\t\t{Porch}" +
                $"\nGarage:\t\t\t{Garage}" +
                $"\nProjected Rental Amount:\t{ProjectedRentalAmt().ToString("C")}" +
                $"\n";
        }
    }
}
