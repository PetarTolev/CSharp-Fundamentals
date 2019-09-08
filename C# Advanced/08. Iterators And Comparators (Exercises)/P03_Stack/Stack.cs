namespace P03_Stack
{
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public Stack()
        {
            this.elements = new List<T>();
        }

        public void Push(params T[] elements)
        {
            foreach (var element in elements)
            {
                this.elements.Add(element);
            }
        }

        public void Pop()
        {
            this.elements.RemoveAt(this.elements.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}