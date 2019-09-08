using System.Collections.Generic;

namespace P06_Strategy_Pattern
{
    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            return first.Age - second.Age;
        }
    }
}
