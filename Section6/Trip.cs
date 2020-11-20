using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Trip
    {
        //Constructors
        public Trip(string dest, int distance, double cost, double fuel)
        {
            Destination = dest;
            DistanceTravelled = distance;
            TotalCostOfFuel = cost;
            FuelConsumed = fuel;
        }

        public Trip(int distance, double cost, double fuel)
        {
            Destination = "Wherever";
            DistanceTravelled = distance;
            TotalCostOfFuel = cost;
            FuelConsumed = fuel;
        }

        //Properties
        public string Destination { get; set; }
        public int DistanceTravelled { get; set; }
        public double TotalCostOfFuel { get; set; }
        public double FuelConsumed { get; set; }

        //Methods
        public double MilesPerGallon()
        {
            return DistanceTravelled / FuelConsumed;
        }

        public double CostPerMile()
        {
            return TotalCostOfFuel / DistanceTravelled;
        }

        public override string ToString()
        {
            return $"Trip to {Destination}: {DistanceTravelled} miles. Money spent on fuel: ${TotalCostOfFuel}. Fuel consumed: {FuelConsumed} gallons.";
        }
    }
}
