using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using SimpleSnake.Utilities;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private DrawManager drawManager;
        private Snake snake;

        public Engine(DrawManager drawManager, Snake snake)
        {
            this.drawManager = drawManager;
            this.snake = snake;
        }

        public void Run()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    this.SetNewDirection(Console.ReadKey());
                }

                this.drawManager.Draw(GameConstants.Snake.Symbol, this.snake.Body);

                this.snake.Move();

                this.drawManager.UndoDrawn();
                
                Thread.Sleep(100);
            }
        }

        private void SetNewDirection(ConsoleKeyInfo input)
        {
            Direction currentSnakeDirection = this.snake.Direction;

            switch (input.Key)
            {
                case ConsoleKey.DownArrow:
                    if (currentSnakeDirection != Direction.Up)
                    {
                        currentSnakeDirection = Direction.Down;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentSnakeDirection != Direction.Right)
                    {
                        currentSnakeDirection = Direction.Left;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (currentSnakeDirection != Direction.Left)
                    {
                        currentSnakeDirection = Direction.Right;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (currentSnakeDirection != Direction.Down)
                    {
                        currentSnakeDirection = Direction.Up;
                    }
                    break;
            }

            this.snake.Direction = currentSnakeDirection;
        }
    }
}
