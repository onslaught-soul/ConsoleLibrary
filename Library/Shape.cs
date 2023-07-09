
using Xunit;

namespace Library
{
    public interface IShape { double Area(); }
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius) => this.radius = radius;

        public double Area() => Math.PI * radius * radius;
    }
    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
        public bool IsRightTriangle()
        {
            double longestSide = Math.Max(sideA, Math.Max(sideB, sideC));
            double sumOfSquares = (sideA * sideA) + (sideB * sideB) + (sideC * sideC);

            return Math.Abs((2 * longestSide * longestSide) - sumOfSquares) < 0.0001;
        }
    }
    public class ShapeCalculator
    {
        public static double Area(IShape shape) => shape.Area();
    }

    public class ShapeCalculatorTests
    {
        public void TestCircleArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            double calculatedArea = ShapeCalculator.Area(circle);
            Assert.Equal(expectedArea, calculatedArea);
        }

        public void TestTriangleArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6;
            double calculatedArea = ShapeCalculator.Area(triangle);
            Assert.Equal(expectedArea, calculatedArea);
        }

        public void TestRightTriangleCheck()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.True(isRightTriangle);
        }
    }
}