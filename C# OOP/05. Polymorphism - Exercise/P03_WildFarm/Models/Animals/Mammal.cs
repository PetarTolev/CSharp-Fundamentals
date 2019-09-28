namespace P03_WildFarm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, string livingRegion)
        {
            base.Name = name;
            base.Weight = weight;
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }
    }
}
