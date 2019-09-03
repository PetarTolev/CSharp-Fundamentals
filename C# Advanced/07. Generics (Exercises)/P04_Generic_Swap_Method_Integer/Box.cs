namespace P04_Generic_Swap_Method_Integer
{
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public Box()
        {
            this.Elements = new List<T>();
        }

        public List<T> Elements { get; set; }

        public void Add(T element)
        {
            Elements.Add(element);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var e in Elements)
            {
                stringBuilder.AppendLine($"{e.GetType()}: {e}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
