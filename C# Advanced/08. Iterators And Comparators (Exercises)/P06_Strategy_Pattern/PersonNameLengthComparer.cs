namespace P06_Strategy_Pattern
{
    using System.Collections.Generic;

    public class PersonNameLengthComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int nameLengthResult = first.Name.Length.CompareTo(second.Name.Length);

            if (first.Name.Length == second.Name.Length)
            {
                return first.Name.ToLower()[0].CompareTo(second.Name.ToLower()[0]);
            }

            return nameLengthResult;
        }
    }
}
