namespace P12_Google
{
    public class Parent
    {
        public Parent(string parentName, string parentBirthday)
        {
            this.ParentName = parentName;
            this.ParentBirthday = parentBirthday;
        }

        public string ParentName { get; set; }

        public string ParentBirthday { get; set; }

        public override string ToString()
        {
            return $"{this.ParentName} {this.ParentBirthday}";
        }
    }
}