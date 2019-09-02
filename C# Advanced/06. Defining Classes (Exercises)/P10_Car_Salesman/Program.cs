namespace P10_Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] inputEngineSpecs = Console.ReadLine().Split(" ",  StringSplitOptions.RemoveEmptyEntries);

                string model = inputEngineSpecs[0];
                int power = int.Parse(inputEngineSpecs[1]);

                Engine engine;

                if (inputEngineSpecs.Length == 3)
                {
                    int displacement;
                    var isDisplacement = int.TryParse(inputEngineSpecs[2], out displacement);

                    if (isDisplacement)
                    {
                        displacement = int.Parse(inputEngineSpecs[2]);

                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficienct = inputEngineSpecs[2];

                        engine = new Engine(model, power, efficienct);
                    }
                }
                else if (inputEngineSpecs.Length == 4)
                {
                    int displacement = int.Parse(inputEngineSpecs[2]);
                    string efficienct = inputEngineSpecs[3];

                    engine = new Engine(model, power, displacement, efficienct);
                }
                else
                {
                    engine = new Engine(model, power);
                }

                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCarSpecs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car;

                string model = inputCarSpecs[0];
                string engineName = inputCarSpecs[1];
                
                Engine engine = engines.First(x => x.Model == engineName);

                if (inputCarSpecs.Length == 3)
                {
                    int weight;
                    var isWeight = int.TryParse(inputCarSpecs[2], out weight);

                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = inputCarSpecs[2];

                        car = new Car(model, engine, color);
                    }
                }
                else if (inputCarSpecs.Length == 4)
                {
                    int weight = int.Parse(inputCarSpecs[2]);
                    string color = inputCarSpecs[3];

                    car = new Car(model, engine, weight, color);
                }
                else
                {
                    car = new Car(model, engine);
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine("    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == null)
                {
                    Console.WriteLine("    Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }

                if (car.Weight == 0)
                {
                    Console.WriteLine("  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }

                if (car.Color == null)
                {
                    Console.WriteLine("  Color: n/a");
                }
                else
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
            }
        }
    }
}
