namespace P03_WildFarm
{
    using Factories;
    using Models;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string animalInput = input;
                Animal animal = AnimalFactory.CreateAnimal(animalInput);
                animals.Add(animal);

                string foodInput = Console.ReadLine();
                Food food = FoodFactory.CreateFood(foodInput);

                try
                {
                    Console.WriteLine(animal.ProduceSound());
                    animal.Eat(food);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
