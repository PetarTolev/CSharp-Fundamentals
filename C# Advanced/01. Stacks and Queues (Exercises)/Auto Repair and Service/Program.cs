namespace Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split().ToArray();

            Queue<string> vehiclesQueue = new Queue<string>(vehicles);
            
            Stack<string> servedVehicles = new Stack<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    if (vehiclesQueue.Count != 0)
                    {
                        Console.WriteLine($"Vehicles for service: {string.Join(", ", vehiclesQueue)}");
                    }

                    Console.WriteLine($"Served vehicles: {string.Join(", ", servedVehicles)}");
                    break;
                }
                else if (command == "Service")
                {
                    if (vehiclesQueue.Count != 0)
                    {
                        string car = vehiclesQueue.Dequeue();

                        servedVehicles.Push(car);

                        Console.WriteLine($"Vehicle {car} got served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedVehicles));
                }
                else
                {
                    string[] splitedCommand = command.Split('-');
                    string car = splitedCommand[1];

                    if (servedVehicles.Contains(car))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
            }
        }
    }
}
