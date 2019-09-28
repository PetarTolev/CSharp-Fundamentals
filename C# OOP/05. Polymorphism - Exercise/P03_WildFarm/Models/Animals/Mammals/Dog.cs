namespace P03_WildFarm.Models.Animals.Mammals
{
    using System;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
            base.Type = "Dog";
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override void Eat(Food food)
        {
            if (food.Type != "Meat")
            {
                throw new ArgumentException($"{this.Type} does not eat {food.Type}!");
            }

            this.Weight += food.Quantity * 0.40;
            base.Eat(food);
        }

        public override string ToString()
        {
            return base.ToString() + $", {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
