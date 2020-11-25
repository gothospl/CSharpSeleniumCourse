using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12
{
    class BodyMassIndexCalculator
    {
        public int Weight { get; set; }
        public int HeightInFeet { get; set; }
        public int HeightInInches { get; set; }

        public BodyMassIndexCalculator()
        {

        }

        public BodyMassIndexCalculator(int lbs, int feet, int inches)
        {
            Weight = lbs;
            HeightInFeet = feet;
            HeightInInches = inches;
        }

        public double CalculateBMI()
        {
            return (Weight * 703) / Math.Pow((HeightInFeet*12 + HeightInInches), 2);
        }

        public override string ToString()
        {
            return $"\nBMI: {CalculateBMI().ToString("F2")}";
        }
    }
}
