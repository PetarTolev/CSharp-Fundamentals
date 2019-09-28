using System;

namespace P09_Collection_Hierarchy.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class MyList : IAdd, IRemove, IUsed
    {
        private List<string> items;

        public MyList()
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
            string item = this.items[0];

            this.items.RemoveAt(0);

            return item;
        }

        public int Used()
        {
            return this.items.Count;
        }
    }
}
