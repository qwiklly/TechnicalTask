using GeometryLib;
using GeometryLib.Figures;
class Program
{
    static void Main()
    {
        IShape circle = new Circle(3);
        IShape triangle = new Triangle(3, 4, 5);

        Console.WriteLine($"Площадь круга: {AreaCalculator.CalculateArea(circle)}");
        Console.WriteLine($"Площадь треугольника: {AreaCalculator.CalculateArea(triangle)}");
    }
}