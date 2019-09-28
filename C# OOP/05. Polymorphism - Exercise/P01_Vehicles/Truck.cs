namespace P01_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConspumption) 
            : base (fuelQuantity, fuelConspumption)
        {
            base.fuelConsupmtion += 1.6;
        }

        public override string Drive(double distance)
        {
            return $"Truck {base.Drive(distance)}";
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}
