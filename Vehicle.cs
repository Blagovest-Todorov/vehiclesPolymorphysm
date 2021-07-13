namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
        }
        public double FuelQuantity { get; protected set; }
        public double FuelConsumptionPerKm { get; protected set; }

        public abstract string Drive(double distance);

        public abstract void Refuel(double litres);

    }
}
