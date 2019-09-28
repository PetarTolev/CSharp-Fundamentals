namespace P03_WildFarm.Models.Animals.Mammals.Felines
{
    using System;

    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            base.Type = "Cat";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override void Eat(Food food)
        {
            if (food.Type != "Vegetable" && food.Type != "Meat")
            {
                throw new ArgumentException($"{this.Type} does not eat {food.Type}!");
            }

            this.Weight += food.Quantity * 0.30;
            base.Eat(food);
        }
    }
}
