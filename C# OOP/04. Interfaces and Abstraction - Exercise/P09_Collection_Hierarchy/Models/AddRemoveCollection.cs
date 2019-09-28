namespace P09_Collection_Hierarchy.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class AddRemoveCollection : IAdd, IRemove
    {
        private List<string> items;

        public AddRemoveCollection()
        {
            this.items = new List<string>();
        }

        public int Add(string item)
        {
            this.items.IndexOf(item, 0);

            this.items.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            int index = this.items.Count - 1;

            string item = this.items[index];

            this.items.RemoveAt(index);

            return item;
        }
    }
}
