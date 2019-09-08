namespace P07_Equality_Logic
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return this.Name == person.Name && this.Age == person.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            int nameResult = this.Name.CompareTo(other.Name);

            if (nameResult == 0)
            {
                return this.Age - other.Age;
            }
            return nameResult;
        }
    } 
}
