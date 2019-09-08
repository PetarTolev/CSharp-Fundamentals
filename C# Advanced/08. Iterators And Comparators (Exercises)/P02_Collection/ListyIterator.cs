namespace P02_Collection
{
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private T[] elements;
        private int index;

        public ListyIterator(params T[] elements)
        {
            this.elements = elements;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.index < this.elements.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.elements.Length == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.elements[this.index]);
            }
        }

        public bool HasNext()
        {
            if (this.index < this.elements.Length - 1)
            {
                return true;
            }

            return false;
        }

        public void PrintAll()
        {
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in elements)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
