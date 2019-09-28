namespace LoggerDemo.Layouts
{
    using Contracts;

    class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
