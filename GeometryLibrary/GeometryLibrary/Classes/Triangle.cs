using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Classes;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        if (!IsValidTriangle())
        {
            throw new ArgumentException("Invalid triangle sides.");
        }
    }

    public double CalculateArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { SideA, SideB, SideC };
        
        Array.Sort(sides);
        
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }

    private bool IsValidTriangle()
    {
        return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
    }
}