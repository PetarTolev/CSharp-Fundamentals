namespace P03_WildFarm.Models.Animals.Birds
{
    using System;

    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
            base.Type = "Owl";
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override void Eat(Food food)
        {
            if (food.Type != "Meat")
            {
                throw new ArgumentException($"{this.Type} does not eat {food.Type}!");
            }

            this.Weight += food.Quantity * 0.25;
            base.Eat(food);
        }

        public override string ToString()
        {
            return $"{this.Type} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
