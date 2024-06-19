using GeometryLib.Figures;

namespace GeometryLibTests
{
    public class TriangleTests
    {
        [Fact]
        public void TestTriangleArea()
        {
            Triangle triangle = new (3, 4, 5);
            double expected = 6;
            Assert.Equal(expected, triangle.GetArea(), 10);
        }

        [Fact]
        public void TestTriangleInvalidSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }

        [Fact]
        public void TestRightTriangle()
        {
            Triangle triangle = new (3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void TestNonRightTriangle()
        {
            Triangle triangle = new (3, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }
    }
}