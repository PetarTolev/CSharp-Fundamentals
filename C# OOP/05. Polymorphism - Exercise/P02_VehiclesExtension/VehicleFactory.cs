namespace P02_VehiclesExtension
{
    public class VehicleFactory
    {
        public static Vehicle CreateVehicle(string input)
        {
            string[] props = input
                .Split();
            string type = props[0];
            double fuelQuantity = double.Parse(props[1]);
            double consumption = double.Parse(props[2]);
            double tankCapacity = double.Parse(props[3]);

            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }

            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantity, consumption, tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantity, consumption, tankCapacity);
                case "Bus":
                    return new Bus(fuelQuantity, consumption, tankCapacity);
            }

            return null;
        }
    }
}
