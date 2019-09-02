namespace P07_Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLines; i++)
            {
                string[] inputCarTokens = Console.ReadLine().Split();

                string model = inputCarTokens[0];
                int fuelAmount = int.Parse(inputCarTokens[1]);
                decimal fuelConsumption = decimal.Parse(inputCarTokens[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumption));
            }

            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand == "End")
                {
                    break;
                }

                string[] splitedInputCommand = inputCommand.Split();

                string carModel = splitedInputCommand[1];
                int amountOfKm = int.Parse(splitedInputCommand[2]);

                var currentCar = cars.FirstOrDefault(x => x.Model == carModel);

                if (Car.CanMoveDistance(currentCar, amountOfKm))
                {
                    currentCar.TraveledDistance += amountOfKm;
                    currentCar.FuelAmount -= amountOfKm * currentCar.FuelConspumption;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
