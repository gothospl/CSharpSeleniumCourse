using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    class PropertyTaxCalculator
    {
        private decimal currentYearAssessedValue;

        public string PropertyAddress { get; set; }
        public decimal LastYearAssessedValue { get; set; }
        public decimal Exemption { get; set; }
        public decimal MillageRate { get; set; }

        public PropertyTaxCalculator(string propertyAddress, decimal lastYearAssessedValue)
        {
            PropertyAddress = propertyAddress;
            LastYearAssessedValue = lastYearAssessedValue;
            Exemption = 25000M;
            MillageRate = 10.03M;
        }

        public decimal CurrentYearAssessedValue()
        {
            return LastYearAssessedValue * 1.027M;
        }

        public decimal TaxableValue()
        {
            return Decimal.Subtract(CurrentYearAssessedValue(), Exemption);
        }

        public decimal TaxesDue()
        {
            return TaxableValue() * MillageRate / 1000M;
        }

        public override string ToString()
        {
            return $"Property Address:\t{PropertyAddress}"+
                $"\nLast Year Assessed Value:\t{LastYearAssessedValue.ToString("c")}"+
                $"\nCurrent Assessed Value:\t{CurrentYearAssessedValue().ToString("c")}"+
                $"\nExemption:\t{Exemption.ToString("c")}"+
                $"\nTaxable Value:\t{TaxableValue().ToString("c")}"+
                $"\nMillage Rate (per $1000):\t{MillageRate.ToString("c")}+" +
                $"\nTaxes Due:\t{TaxesDue().ToString("c")}";
        }

    }
}
