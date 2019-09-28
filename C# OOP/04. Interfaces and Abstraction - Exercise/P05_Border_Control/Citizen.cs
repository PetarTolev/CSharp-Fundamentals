namespace P05_Border_Control
{
    public class Citizen : IIdentifiable
    {
        private string name;
        private int age;
        private string id;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public string Id
        {
            get => this.id;
        }
    }
}
