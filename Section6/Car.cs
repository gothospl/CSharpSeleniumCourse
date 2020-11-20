using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Car
    {
        public string color;
        public int numberOfDoors;
        public bool isConvertable;

        public string Color
        {
            get
            { return color; }
            set
            { color = value; }
        }

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if (value <= 5)
                {
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("Get real. Less than 6 doors.");
                }
            }
        }

        public bool IsConvertable { get; set; }

        public Car(string carColor, int doors, bool convertable)
        {
            Color = carColor;
            NumberOfDoors = doors;
            IsConvertable = convertable;
        }
    }
}
