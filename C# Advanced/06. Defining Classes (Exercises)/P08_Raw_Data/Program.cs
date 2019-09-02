namespace P08_Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            
            int numbersOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfCars; i++)
            {
                string[] inputCar = Console.ReadLine().Split();
                
                string model = inputCar[0];

                int engineSpeed = int.Parse(inputCar[1]);
                int enginePower = int.Parse(inputCar[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(inputCar[3]);
                string cargoType = inputCar[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);


                int tireCounter = 0;
                Tire[] tires = new Tire[4];
                for (int j = 5; j < inputCar.Length - 1; j += 2)
                {
                    decimal pressure = decimal.Parse(inputCar[j]);
                    int age = int.Parse(inputCar[j + 1]);

                    tires[tireCounter] = new Tire(pressure, age);
                    tireCounter++;
                }

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string inputCommand = Console.ReadLine();

            List<Car> resultCars = new List<Car>();

            if (inputCommand == "fragile")
            {
                resultCars = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(t => t.TirePressure < 1)).ToList();
            }
            else if (inputCommand == "flamable")
            {
                resultCars = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
            }

            foreach (var car in resultCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
