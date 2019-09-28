namespace P06_Birthday_Celebrations
{
    public class Citizen : IBirthDate
    {
        private string birthDate;

        public Citizen(string birthDate)
        {
            this.birthDate = birthDate;
        }

        public string BirthDate
        {
            get => this.birthDate;
        }
    }
}
