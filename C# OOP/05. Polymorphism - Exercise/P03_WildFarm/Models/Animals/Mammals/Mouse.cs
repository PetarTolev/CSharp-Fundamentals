namespace P03_WildFarm.Models.Animals.Mammals
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
            base.Type = "Mouse";
        }
        
        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void Eat(Food food)
        {
            if (food.Type != "Vegetable" && food.Type != "Fruit")
            {
                throw new ArgumentException($"{this.Type} does not eat {food.Type}!");
            }

            this.Weight += food.Quantity * 0.10;
            base.Eat(food);
        }

        public override string ToString()
        {
            return base.ToString() + $", {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
