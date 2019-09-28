namespace P09_Collection_Hierarchy.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class AddCollection : IAdd
    {
        private List<string> items;

        public AddCollection()
        {
            this.items = new List<string>();
        }

        public int Add(string item)
        {
            this.items.Add(item);

            return this.items.Count - 1;
        }
    }
}
