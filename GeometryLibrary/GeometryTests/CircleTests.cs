using GeometryLibrary.Classes;

namespace GeometryTests;

public class CircleTests
{
    [Theory]
    [InlineData(1, Math.PI * 1 * 1)]
    [InlineData(2, Math.PI * 2 * 2)]
    [InlineData(3, Math.PI * 3 * 3)]
    [InlineData(4, Math.PI * 4 * 4)]
    [InlineData(5, Math.PI * 5 * 5)]
    public void CalculateArea_ReturnsCorrectResult(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        
        Assert.Equal(expectedArea, circle.CalculateArea(), precision: 5);
    }
}