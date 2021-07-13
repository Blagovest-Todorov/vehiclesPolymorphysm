using System;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override string Drive(double distance)
        {
            bool canDrive = FuelQuantity >= distance * (FuelConsumptionPerKm + 0.9); 

            if (canDrive == false)
            {
               return "Car needs refueling";
            }

            this.FuelQuantity -= distance * (FuelConsumptionPerKm + 0.9);
            return $"Car travelled {distance} km";
        }

        public override void Refuel(double litres)
        {
            this.FuelQuantity += litres;            
        }
    }
}
