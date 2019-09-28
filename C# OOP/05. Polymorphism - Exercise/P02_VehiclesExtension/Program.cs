namespace P02_VehiclesExtension
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string carInfo = Console.ReadLine();
            Car car = (Car)VehicleFactory.CreateVehicle(carInfo);

            string truckInfo = Console.ReadLine();
            Truck truck = (Truck)VehicleFactory.CreateVehicle(truckInfo);

            string busInfo = Console.ReadLine();
            Bus bus = (Bus)VehicleFactory.CreateVehicle(busInfo);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandProps = Console.ReadLine()
                    .Split();
                string command = commandProps[0];
                string vehicleType = commandProps[1];
                double value = double.Parse(commandProps[2]);

                switch (vehicleType)
                {
                    case "Car":
                        car = (Car) Command(command, value, car);
                        break;
                    case "Truck":
                        truck = (Truck) Command(command, value, truck);
                        break;
                    case "Bus":
                        if (command == "DriveEmpty")
                        {
                            Console.WriteLine(bus.DriveEmpty(value));
                        }
                        else
                        {
                            bus = (Bus) Command(command, value, bus);
                        }
                        break;
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        public static Vehicle Command(string command, double value, Vehicle vehicle)
        {
            switch (command)
            {
                case "Drive":
                    Console.WriteLine(vehicle.Drive(value));
                    break;
                case "Refuel":
                    try
                    {
                        vehicle.Refuel(value);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
            return vehicle;
        }
    }
}
