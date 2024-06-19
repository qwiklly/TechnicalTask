namespace GeometryLib.Figures
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше 0");
            }
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}