namespace P12_Google
{
    public class Children
    {
        public Children(string childrenName, string childrenBirthday)
        {
            this.ChildrenName = childrenName;
            this.ChildrenBirthday = childrenBirthday;
        }

        public string ChildrenName { get; set; }

        public string ChildrenBirthday { get; set; }

        public override string ToString()
        {
            return $"{ChildrenName} {ChildrenBirthday}";
        }
    }
}
