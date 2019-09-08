using System;

namespace P05_Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            if (this.name == other.name)
            {
                if (this.age == other.age)
                {
                    if (this.town == other.town)
                    {
                        return 0;
                    }
                    return 1;
                }
                return 1;
            }
            return 1;
        }
    }
}
