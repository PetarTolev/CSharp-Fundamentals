namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string secondName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age <= 30)
            {
                percentage /= 2;
            }

            this.Salary += (this.Salary * percentage / 100);
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName} receives {this.Salary:f2} leva.";
        }
    }
}