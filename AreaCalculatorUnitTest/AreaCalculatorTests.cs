using AreaCalculator;

namespace AreaCalculatorUnitTest
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void WrongCircleRadius()
        {
            double radius = -1;

            Assert.Throws<ArgumentException>(() => Calculator.GetCircleArea(radius));

            radius = -10;

            Assert.Throws<ArgumentException>(() => Calculator.GetCircleArea(radius));

            radius = 0;

            Assert.Throws<ArgumentException>(() => Calculator.GetCircleArea(radius));
        }

        [Fact]
        public void CircleAreaCalculations()
        {
            double radius = 1;
            Assert.Equal(Math.PI, Calculator.GetCircleArea(radius));

            radius = 4;
            double rightArea = 50.265482456;
            double calculatedArea = Calculator.GetCircleArea(radius);

            Assert.Equal(Math.Round(rightArea, 5), Math.Round(calculatedArea, 5));

            radius = 8;
            rightArea = 201.061929824;
            calculatedArea = Calculator.GetCircleArea(radius);

            Assert.Equal(Math.Round(rightArea, 5), Math.Round(calculatedArea, 5));

            radius = 100;
            rightArea = 31415.926535;
            calculatedArea = Calculator.GetCircleArea(radius);

            Assert.Equal(Math.Round(rightArea, 5), Math.Round(calculatedArea, 5));
        }

        [Fact]
        public void WrongTriangleSides()
        {
            double x = 0;
            double y = 0;
            double z = 0;

            Assert.Throws<ArgumentException>(() => Calculator.GetTriangleArea(x, y, z));

            x = 10;
            y = 5;
            z = 2;

            Assert.Throws<ArgumentException>(() => Calculator.GetTriangleArea(x, y, z));

            x = 5;
            y = 10;
            z = 2;

            Assert.Throws<ArgumentException>(() => Calculator.GetTriangleArea(x, y, z));

            x = 5;
            y = 2;
            z = 10;

            Assert.Throws<ArgumentException>(() => Calculator.GetTriangleArea(x, y, z));
        }

        [Fact]
        public void TriangleAreaCalculations()
        {
            double x = 12;
            double y = 7;
            double z = 6;
            double rightArea = 14.947826;
            double calculatedArea = Calculator.GetTriangleArea(x, y, z);

            Assert.Equal(Math.Round(rightArea, 5), Math.Round(calculatedArea, 5));

            x = 46;
            y = 32;
            z = 50;
            rightArea = 718.398218;
            calculatedArea = Calculator.GetTriangleArea(x, y, z);

            Assert.Equal(Math.Round(rightArea, 5), Math.Round(calculatedArea, 5));
        }

        [Fact]
        public void CheckIfTriangleRightWrongSides()
        {
            double x = 0;
            double y = 0;
            double z = 0;

            Assert.Throws<ArgumentException>(() => Calculator.CheckIsTriangleRight(x, y, z));

            x = 10;
            y = 5;
            z = 2;

            Assert.Throws<ArgumentException>(() => Calculator.CheckIsTriangleRight(x, y, z));

            x = 5;
            y = 10;
            z = 2;

            Assert.Throws<ArgumentException>(() => Calculator.CheckIsTriangleRight(x, y, z));

            x = 5;
            y = 2;
            z = 10;

            Assert.Throws<ArgumentException>(() => Calculator.CheckIsTriangleRight(x, y, z));
        }

        [Fact]
        public void CheckIfTriangleRight()
        {
            double x = 3;
            double y = 4;
            double z = 5;

            Assert.True(Calculator.CheckIsTriangleRight(x, y, z));

            x = 6;
            y = 8;
            z = 10;

            Assert.True(Calculator.CheckIsTriangleRight(x, y, z));

            x = 5;
            y = 7;
            z = 5;

            Assert.False(Calculator.CheckIsTriangleRight(x, y, z));

            x = 14;
            y = 15;
            z = 13;

            Assert.False(Calculator.CheckIsTriangleRight(x, y, z));
        }
    }
}