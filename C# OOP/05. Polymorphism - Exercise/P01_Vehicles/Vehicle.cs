namespace P01_Vehicles
{
    public abstract class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsupmtion;

        public Vehicle(double fuelQuantity, double fuelConsupmtion)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsupmtion = fuelConsupmtion;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
        }

        public double FuelConspumption
        {
            get => this.fuelConsupmtion;
        }

        public virtual string Drive(double distance)
        {
            double consumedFuel = distance * fuelConsupmtion;

            if (this.fuelQuantity < consumedFuel)
            {
                return "needs refueling";
            }

            this.fuelQuantity -= consumedFuel;
            return $"travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            this.fuelQuantity += liters;
        }
    }
}
