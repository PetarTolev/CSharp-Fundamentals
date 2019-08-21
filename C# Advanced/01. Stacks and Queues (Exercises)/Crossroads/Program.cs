namespace Crossroads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int durationOfFreeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int countOfPassedCars = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else if (input == "green")
                {
                    int reminderOfGreenLight = durationOfGreenLight;

                    while (cars.Any() && reminderOfGreenLight > 0)
                    {
                        if (cars.Peek().Length <= reminderOfGreenLight)
                        {
                            reminderOfGreenLight -= cars.Dequeue().Length;
                            countOfPassedCars++;
                        }
                        else if (cars.Peek().Length == reminderOfGreenLight)
                        {
                            reminderOfGreenLight = 0;
                            cars.Dequeue();
                            countOfPassedCars++;
                        }
                        else
                        {
                            string car = cars.Dequeue();
                            Queue<char> partsOfCar = new Queue<char>(car);

                            while (reminderOfGreenLight > 0)
                            {
                                if (partsOfCar.Any())
                                {
                                    partsOfCar.Dequeue();
                                    reminderOfGreenLight--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            int reminderOfFreeWindow = durationOfFreeWindow;

                            while (reminderOfFreeWindow > 0)
                            {
                                if (partsOfCar.Any())
                                {
                                    partsOfCar.Dequeue();
                                    reminderOfFreeWindow--;
                                    if (!partsOfCar.Any())
                                    {
                                        countOfPassedCars++;
                                        break;
                                    }

                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (partsOfCar.Any())
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {partsOfCar.Peek()}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{countOfPassedCars} total cars passed the crossroads.");
        }
    }
}
