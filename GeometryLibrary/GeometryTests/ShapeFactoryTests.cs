using GeometryLibrary.Classes;
using GeometryLibrary.Factories;

namespace GeometryTests;

public class ShapeFactoryTests
{
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(15)]
    public void CreateCircle_ReturnsCircleWithCorrectRadius(double radius)
    {
        var shape = ShapeFactory.CreateCircle(radius);
        var circle = (Circle)shape;    
        
        Assert.IsType<Circle>(shape);
        Assert.Equal(radius, circle.Radius);
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(6, 8, 10)]
    [InlineData(5, 12, 13)]
    public void CreateTriangle_ReturnsTriangleWithCorrectSides(double sideA, double sideB, double sideC)
    {
        var shape = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
        
        var triangle = (Triangle)shape;
        
        Assert.IsType<Triangle>(shape);
        Assert.Equal(sideA, triangle.SideA);
        Assert.Equal(sideB, triangle.SideB);
        Assert.Equal(sideC, triangle.SideC);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, 1, 1)]
    [InlineData(10, 2, 7)]
    public void CreateTriangle_ThrowsExceptionForInvalidSides(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(sideA, sideB, sideC));
    }
}