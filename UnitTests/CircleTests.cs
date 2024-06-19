using GeometryLib.Figures;

namespace GeometryLibTests
{
    public class CircleTests
    {
        [Fact]
        public void TestCircleArea()
        {
            Circle circle = new(5);
            double expected = Math.PI * 25;
            Assert.Equal(expected, circle.GetArea(), 10);
        }

        [Fact]
        public void TestCircleInvalidRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
