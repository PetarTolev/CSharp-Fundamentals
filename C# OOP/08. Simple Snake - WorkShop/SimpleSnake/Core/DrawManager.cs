using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSnake.GameObjects;
using SimpleSnake.Utilities;

namespace SimpleSnake.Core
{
    public class DrawManager
    {
        private List<Coordinate> lastDrawnElements;

        public DrawManager()
        {
            this.lastDrawnElements = new List<Coordinate>();
        }

        public void Draw(string symbol, IReadOnlyCollection<Coordinate> coordinates)
        {
            foreach (var coordinate in coordinates)
            {
                if (symbol == GameConstants.Snake.Symbol)
                {
                    this.lastDrawnElements.Add(new Coordinate(coordinate.CoordinateX, coordinate.CoordinateY));
                }

                this.DrawOperation(symbol, coordinate);
            }
        }

        public void DrawOperation(string symbol, Coordinate coordinate)
        {
            Console.SetCursorPosition(coordinate.CoordinateX, coordinate.CoordinateY);
            Console.Write(symbol);
        }

        public void UndoDrawn()
        {
            if (this.lastDrawnElements.Any())
            {
                this.DrawOperation(" ", this.lastDrawnElements.First());
                this.lastDrawnElements.Clear();
            }
        }
    }
}
