namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = parameters[0];

                var engineSpeed = int.Parse(parameters[1]);
                var enginePower = int.Parse(parameters[2]);
                var engine = new Engine(engineSpeed, enginePower);

                var cargoWeight = int.Parse(parameters[3]);
                var cargoType = parameters[4];
                var cargo = new Cargo(cargoWeight, cargoType);

                var tires = new List<Tire>();

                for (int j = 5; j < parameters.Length; j += 2)
                {
                    var tirePressure = double.Parse(parameters[j]);
                    var tireAge = int.Parse(parameters[j + 1]);

                    var tire = new Tire(tirePressure, tireAge);

                    tires.Add(tire);
                }

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var fragile = cars
                    .Where(x => x.cargo.CargoType == "fragile" && x.tires.Any(y => y.TirePresure < 1))
                    .Select(x => x.model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                var flamable = cars
                    .Where(x => x.cargo.CargoType == "flamable" && x.engine.EnginePower > 250)
                    .Select(x => x.model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}