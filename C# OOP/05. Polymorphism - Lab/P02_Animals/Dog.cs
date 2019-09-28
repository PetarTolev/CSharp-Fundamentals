namespace Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, string favourite) 
            : base(name, favourite)
        {
        }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "DJAAF";
        }

    }
}
