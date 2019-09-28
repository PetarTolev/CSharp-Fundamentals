namespace SimpleSnake
{
    using Core;
    using GameObjects;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            DrawManager drawManager = new DrawManager();

            Snake snake = new Snake();

            Engine engine = new Engine(drawManager, snake);

            engine.Run();
        }
    }
}
