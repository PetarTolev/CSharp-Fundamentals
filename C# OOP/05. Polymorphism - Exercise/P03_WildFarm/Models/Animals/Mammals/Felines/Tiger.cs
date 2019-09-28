namespace P03_WildFarm.Models.Animals.Mammals.Felines
{
    using System;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            base.Type = "Tiger";
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

        public override void Eat(Food food)
        {
            if (food.Type != "Meat")
            {
                throw new ArgumentException($"{this.Type} does not eat {food.Type}!");
            }

            this.Weight += food.Quantity * 1;
            base.Eat(food);
        }

        public override string ToString()
        {
            return $"{this.Type} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
