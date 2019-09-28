namespace P01_Vehicles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine()
                .Split();
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            Car car = new Car(carFuelQuantity, carConsumption);

            string[] truckInfo = Console.ReadLine()
                .Split();
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);
            Truck truck = new Truck(truckFuelQuantity, truckConsumption);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandProps = Console.ReadLine()
                    .Split();
                string command = commandProps[0];
                string vehicleType = commandProps[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandProps[2]);

                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (vehicleType == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else if (command == "Refuel")
                {
                    double liters = double.Parse(commandProps[2]);

                    if (vehicleType == "Car")
                    {
                        car.Refuel(liters);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(liters);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
