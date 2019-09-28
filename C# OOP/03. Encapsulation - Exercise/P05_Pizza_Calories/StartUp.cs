namespace P05_Pizza_Calories
{
    using System;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            string[] pizzaProps = Console.ReadLine().Split();
            string pizzaName = pizzaProps[1];

            string[] doughProps = Console.ReadLine().Split();
            string floor = doughProps[1];
            string backingTechnique = doughProps[2];
            double doughWeight = double.Parse(doughProps[3]);

            try
            {
                Dough dough = new Dough(floor, backingTechnique, doughWeight);

                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    string[] toppingProps = input.Split();
                    string toppingType = toppingProps[1];
                    double toppingWeight = double.Parse(toppingProps[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddToppint(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories():f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
