namespace P02_VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConspumption, double tankCapacity) 
            : base (fuelQuantity, fuelConspumption, tankCapacity)
        {
            base.FuelConsumption += 1.6;
        }

        public override string Drive(double distance)
        {
            return $"Truck {base.Drive(distance)}";
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount);
            this.FuelQuantity -= (fuelAmount * 0.05);
        }
    }
}
