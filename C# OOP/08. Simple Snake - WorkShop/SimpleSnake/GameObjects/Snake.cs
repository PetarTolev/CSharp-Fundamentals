namespace SimpleSnake.GameObjects
{
    using Enums;
    using Foods;
    using System.Collections.Generic;
    using System.Linq;

    public class Snake
    {
        private List<Coordinate> snakeBody;
        private Direction currentDirection;

        public Snake()
        {
            snakeBody = new List<Coordinate>();
            this.InitializeDefaultSnake();
            this.Direction = Direction.Right;
        }

        public IReadOnlyCollection<Coordinate> Body => this.snakeBody.AsReadOnly();
        public Direction Direction { get; set; }

        private void InitializeDefaultSnake()
        {
            int x = 5;
            int y = 6;

            for (int i = 1; i < 6; i++)
            {
                this.snakeBody.Add(new Coordinate(x++, y));
            }
        }

        public void Move()
        {
            Coordinate currentHead = this.snakeBody.Last();

            Coordinate newHeadCoordinate =
                this.CalculateNewCoordinate(new Coordinate(currentHead.CoordinateX, currentHead.CoordinateY));

            this.snakeBody.Add(newHeadCoordinate);
            this.snakeBody.RemoveAt(0);
        }

        public void Eat(Food food)
        {
            for (int i = 0; i < food.FoodPoints; i++)
            {
                Coordinate coordinate = new Coordinate(this.snakeBody.Last().CoordinateX, this.snakeBody.Last().CoordinateY);
                this.snakeBody.Add(this.CalculateNewCoordinate(coordinate));

                //todo not sure
            }
        }

        public Coordinate CalculateNewCoordinate(Coordinate newCoordinate)
        {
            switch (this.Direction)
            {
                case Direction.Right:
                    newCoordinate.CoordinateX += 1;
                    break;
                case Direction.Left:
                    newCoordinate.CoordinateX -= 1;
                    break;
                case Direction.Down:
                    newCoordinate.CoordinateY += 1;
                    break;
                case Direction.Up:
                    newCoordinate.CoordinateY -= 1;
                    break;
            }

            return newCoordinate;
        }
    }
}
