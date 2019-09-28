namespace P06_Birthday_Celebrations
{
    public class Pet : IBirthDate
    {
        private string name;
        private string birthDate;

        public Pet(string name, string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public string BirthDate
        {
            get => this.birthDate;
        }
    }
}
