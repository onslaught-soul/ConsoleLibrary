using System;
using static ClassLibrary.Shape;

namespace ConsoleLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCalculatorTests shapeCalculatorTests = new ShapeCalculatorTests();

            shapeCalculatorTests.TestCircleArea();
            shapeCalculatorTests.TestTriangleArea();
            shapeCalculatorTests.TestRightTriangleCheck();

            Console.ReadLine();
        }
    }
}
