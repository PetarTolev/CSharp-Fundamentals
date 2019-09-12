namespace Repository
{
    using System;

    using System.Collections.Generic;

    public class Repository
    {
        private int id;
        private Dictionary<int, Person> people;

        public Repository()
        {
            this.id = 0;
            this.people = new Dictionary<int, Person>();
        }

        public int Count { get; set; } 

        public void Add(Person person)
        {
            this.people.Add(id, person);
            id++;
            this.Count = people.Count;
        }

        public Person Get(int id)
        {
            Person person = people[id];

            return person;
        }

        public bool Update(int id, Person newPerson)
        {
            if (people.ContainsKey(id))
            {
                people[id] = newPerson;

                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (people.ContainsKey(id))
            {
                people.Remove(id);
                this.Count = people.Count;

                return true;
            }

            return false;
        }
    }
}
