using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Classes;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return  Math.PI * Radius * Radius;
    }
}