namespace LoggerDemo.Layouts
{
    using Contracts;
    using System.Text;

    public class XmlLayout : ILayout
    {
        public string Format => CreateFormat();

        private static string CreateFormat()
        {
            StringBuilder format = new StringBuilder();

            format.AppendLine("<log>");
            format.AppendLine("   <date>{0}</date>");
            format.AppendLine("   <level>{1}</level>");
            format.AppendLine("   <message>{2}</message>");
            format.Append("</log>");

            return format.ToString();
        }
    }
}
