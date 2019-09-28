namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public override double CalculatePerimeter()
        {
            return (this.height * 2) + (this.width * 2);
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
