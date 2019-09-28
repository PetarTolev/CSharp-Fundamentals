namespace P02_CarsSalesman
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            CarFactory carFactory = new CarFactory();
            EngineFactory engineFactory = new EngineFactory();

            CarSalesman carSalesman = new CarSalesman(carFactory, engineFactory);

            var engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                var parameters = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                carSalesman.AddEngine(parameters);
            }

            var carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                var parameters = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                carSalesman.AddCar(parameters);
            }

            foreach (var car in carSalesman.GetCars())
            {
                Console.WriteLine(car);
            }
        }
    }
}