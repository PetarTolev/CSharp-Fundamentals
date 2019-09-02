using System;

namespace P09_Rectangle_Intersection
{
    public class Rectangle
    {
        public Rectangle(string id, int width, int height, int x, int y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public string Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public static string CheckForIntersectBetweenRectagles(Rectangle firstRectengle, Rectangle secondRectangle)
        {
            if (Math.Abs(firstRectengle.X) < Math.Abs(secondRectangle.X + secondRectangle.Width))
            {
                if (Math.Abs(firstRectengle.X + firstRectengle.Width) >= Math.Abs(secondRectangle.X))
                {
                    if (firstRectengle.Y < Math.Abs((secondRectangle.Y - secondRectangle.Height)))
                    {
                        if (Math.Abs(firstRectengle.Y + firstRectengle.Height) >= Math.Abs(secondRectangle.Y))
                        {
                            return "true";
                        }
                    }
                }
            }

            return "false";
        }
    }
}
