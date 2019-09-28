namespace P02_Point_in_Rectangle
{
    public class Rectangle
    {
        public Rectangle(Point topLeftPoint, Point bottomRightPoint)
        {
            this.TopLeftPoint = topLeftPoint;
            this.BottomRightPoint = bottomRightPoint;
        }

        public Point TopLeftPoint { get; set; }

        public Point BottomRightPoint { get; set; }

        public bool Contains(Point point)
        {
            if (point.X >= this.TopLeftPoint.X && point.Y <= this.BottomRightPoint.Y &&
                point.Y >= this.TopLeftPoint.Y && point.X <= this.BottomRightPoint.X)
            {
                return true;
            }
            return false;
        }
    }
}