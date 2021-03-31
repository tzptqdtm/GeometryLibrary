using System;

namespace GeometryLibrary
{
    public abstract class Shape: IArea
    {
        public abstract double GetArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be equal or greater than zero");
            }

            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

    }
    public class Triangle : Shape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool IsRightTriangle()
        {
            double[] nums = { A, B, C };

            Array.Sort(nums);

            return Math.Abs(nums[2] * nums[2] - (nums[0] * nums[0] + nums[1] * nums[1])) < double.Epsilon;
        }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("All sides must be equal or greater than zero");
            }

            double p = (a + b + c) / 2;

            if (p < a || p < b || p < c)
            {
                throw new ArgumentException("Input error. Some sides must be longer");
            }

            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    public class Square : Shape
    {
        public double Side { get; }
        public Square(double n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Side must be equal or greater than zero");
            }

            Side = n;
        }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
