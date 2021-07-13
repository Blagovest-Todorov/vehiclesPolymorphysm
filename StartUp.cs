using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            string[] carData = Console.ReadLine().Split();
            string[] truckData = Console.ReadLine().Split();
            int numberCommands = int.Parse(Console.ReadLine());

           double fuelQuantity = double.Parse(carData[1]);
           double fuelConsumption = double.Parse(carData[2]);
           
           double truckFuelQuantity = double.Parse(truckData[1]);
           double truckFuelConsumption = double.Parse(truckData[2]);

            Vehicle vehicleCar = new Car(fuelQuantity, fuelConsumption);
            Vehicle vehicleTruck = new Truck(truckFuelQuantity, truckFuelConsumption);
            vehicles.Add(vehicleCar);
            vehicles.Add(vehicleTruck);

            for (int i = 0; i < numberCommands; i++)
            {
                string[] commandParts = Console.ReadLine().Split();

                if (commandParts[0] == "Drive" && commandParts[1] == nameof(Car))
                {
                    double distance = double.Parse(commandParts[2]);

                    Console.WriteLine(vehicleCar.Drive(distance));

                }
                else if (commandParts[0] == "Drive" && commandParts[1] == nameof(Truck))
                {
                    double distance = double.Parse(commandParts[2]);

                    Console.WriteLine(vehicleTruck.Drive(distance));
                }
                else if (commandParts[0] == "Refuel" && commandParts[1] == nameof(Car))
                {
                    double litres = double.Parse(commandParts[2]);
                    Vehicle vehicle = vehicles.FirstOrDefault(ve => ve is Car);
                    vehicle.Refuel(litres);
                }
                else if (commandParts[0] == "Refuel" && commandParts[1] == nameof(Truck))
                {
                    double litres = double.Parse(commandParts[2]);
                    Vehicle currVehicle = vehicles.FirstOrDefault(ve => ve is Truck);
                    currVehicle.Refuel(litres);
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.GetType().Name}: {vehicle.FuelQuantity:F2}");
            }
        }
    }
}
