namespace P01_Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double CalculateSurfaceArea()
        {
            double result = 2 * length * width + 2 * width * height + 2 * length * height;

            return result;
        }

        public double CalculateLateralSurfaceArea()
        {
            double result = 2 * length * height + 2 * width * height;

            return result;
        }

        public double CalculateVolume()
        {
            double result = length * width * height;

            return result;
        }
    }
}
