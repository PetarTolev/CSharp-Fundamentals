namespace P01_ListyIterator
{
    using System;

    public class ListyIterator<T>
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
    }
}
