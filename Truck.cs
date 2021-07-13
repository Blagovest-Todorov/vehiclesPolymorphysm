namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override string Drive(double distance)
        {
            bool canDrive = FuelQuantity >= distance * (FuelConsumptionPerKm + 1.6);

            if (canDrive == false)
            {
                return "Truck needs refueling";
            }

            FuelQuantity -= distance * (FuelConsumptionPerKm + 1.6);
            return $"Truck travelled {distance} km";            
        }

        public override void Refuel(double litres)
        {
            this.FuelQuantity += 0.95 * litres;  // 95 %   
        }
    }
}
