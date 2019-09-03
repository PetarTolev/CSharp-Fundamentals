namespace P05_Generic_Count_Method_Strings
{
    using System.Collections.Generic;

    public class Box<T>
    {
        public Box()
        {
            this.Elements = new List<T>();
        }

        public List<T> Elements { get; set; }

        public void Add(T element)
        {
            this.Elements.Add(element);
        }
    }
}
