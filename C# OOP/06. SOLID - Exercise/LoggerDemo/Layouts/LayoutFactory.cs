using System;

namespace LoggerDemo.Layouts
{
    using Contracts;

    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreatLayout(string type)
        {
            string typeAsLower = type.ToLower();

            switch (typeAsLower)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}
