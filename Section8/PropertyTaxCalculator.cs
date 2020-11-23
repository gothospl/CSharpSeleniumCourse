using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    class PropertyTaxCalculator
    {
        private decimal millage_rate = 10.03M;
        private decimal assessment_increase = 0.027M;
        private decimal exemption = 25000M;

        public string PropertyAddress { get; set; }
        public decimal LastYearAssessedValue { get; set; }

        public PropertyTaxCalculator(string propertyAddress, decimal lastYearAssessedValue)
        {
            PropertyAddress = propertyAddress;
            LastYearAssessedValue = lastYearAssessedValue;
        }

        public decimal CurrentYearAssessedValue()
        {
            return LastYearAssessedValue * (1M + assessment_increase);
        }

        public decimal TaxableValue()
        {
            return Decimal.Subtract(CurrentYearAssessedValue(), exemption);
        }

        public decimal TaxesDue()
        {
            return TaxableValue() * millage_rate / 1000M;
        }

        public override string ToString()
        {
            return $"Property Address:\t{PropertyAddress}"+
                $"\nLast Year Assessed Value:\t{LastYearAssessedValue.ToString("c")}"+
                $"\nCurrent Assessed Value:\t{CurrentYearAssessedValue().ToString("c")}"+
                $"\nExemption:\t{exemption.ToString("c")}"+
                $"\nTaxable Value:\t{TaxableValue().ToString("c")}"+
                $"\nMillage Rate (per $1000):\t{millage_rate.ToString("c")}+" +
                $"\nTaxes Due:\t{TaxesDue().ToString("c")}";
        }

    }
}
