namespace LoggerDemo.Layouts.Contracts
{
    public interface ILayoutFactory
    {
        ILayout CreatLayout(string type);
    }
}
