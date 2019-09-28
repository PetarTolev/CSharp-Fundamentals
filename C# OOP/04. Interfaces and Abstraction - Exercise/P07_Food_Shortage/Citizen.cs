namespace P07_Food_Shortage
{
    public class Citizen : IBuyer
    {
        private string name;
        private int food;

        public Citizen(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => this.name;
        }

        public int Food
        {
            get => this.food;
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
