using System;

namespace P02_VehiclesExtension
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; protected set; }

        public virtual string Drive(double distance)
        {
            double consumedFuel = distance * FuelConsumption;

            if (this.FuelQuantity < consumedFuel)
            {
                return "needs refueling";
            }

            this.FuelQuantity -= consumedFuel;
            return $"travelled {distance} km";
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            double freeSpeceInTank = this.TankCapacity - this.FuelQuantity;

            if (freeSpeceInTank < fuelAmount)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }

            this.FuelQuantity += fuelAmount;
        }
    }
}
