namespace GenericScale
{
    public class EqualityScale<T>
    {
        public EqualityScale(T leftItem, T rightItem)
        {
            this.LeftItem = leftItem;
            this.RightItem = rightItem;
        }

        public T LeftItem { get; set; }

        public T RightItem { get; set; }

        public bool AreEqual()
        {
            if (this.LeftItem.Equals(this.RightItem))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
