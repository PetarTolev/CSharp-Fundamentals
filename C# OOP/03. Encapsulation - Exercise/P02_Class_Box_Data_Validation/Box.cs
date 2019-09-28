using System;

namespace P02_Class_Box_Data_Validation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.Length;

            private set
            {
                ValidateInputData(value, "Length");

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;

            private set
            {
                ValidateInputData(value, "Width");

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;

            private set
            {
                ValidateInputData(value, "Height");

                this.height = value;
            }
        }

        private void ValidateInputData(double data, string type)
        {
            if (data < 0)
            {
                throw new ArgumentException($"{type} cannot be zero or negative. ");
            }
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
