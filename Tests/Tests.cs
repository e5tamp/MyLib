using MyLib;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(13, 14, 15, 84)]
        public void TestTriangleGetSquare(double a, double b, double c, double square)
        {
            Triangle triangle = new Triangle();

            triangle.Lines.Add(a);
            triangle.Lines.Add(b);
            triangle.Lines.Add(c);

            Assert.Equal(triangle.GetSquare(), square);
        }

        [Theory]
        [InlineData(13, 14, 15, 84)]
        public void TestTriangleGetSquareFromShape(double a, double b, double c, double square)
        {
            Triangle triangle = new Triangle();

            triangle.Lines.Add(a);
            triangle.Lines.Add(b);
            triangle.Lines.Add(c);

            Assert.Equal(GetSquareOfShape(triangle), square);
        }

        [Theory]
        [InlineData(3, 28.274333882308138)]
        public void TestCircleGetSquare(double a, double square)
        {
            Circle circle = new Circle();

            circle.Lines.Add(a);

            Assert.Equal(circle.GetSquare(), square);
        }

        [Fact]
        public void TestTriangleLinesOverflow()
        {
            Triangle triangle = new Triangle();

            triangle.Lines.Add(6);
            triangle.Lines.Add(8);
            triangle.Lines.Add(10);

            Assert.Throws<LinesOverflowException>(() => triangle.Lines.Add(12));
        }

        [Fact]
        public void TestCircleLinesOverflow()
        {
            Circle circle = new Circle();

            circle.Lines.Add(6);

            Assert.Throws<LinesOverflowException>(() => circle.Lines.Add(12));
        }

        /// <summary>
        /// Пример нахождения площади фигуры не зная типа фигуры
        /// </summary>
        public double GetSquareOfShape(Shape shape)
        {
            return shape.GetSquare();
        }
    }
}
