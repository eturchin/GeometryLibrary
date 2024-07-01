using GeometryLibrary.Classes;

namespace GeometryTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(6, 8, 10, 24)]
    [InlineData(5, 12, 13, 30)]
    public void CalculateArea_ReturnsCorrectResult(double sideA, double sideB, double sideC, double expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        
        Assert.Equal(expectedArea, triangle.CalculateArea(), precision: 5);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(6, 8, 10, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(3, 4, 6, false)]
    [InlineData(7, 10, 12, false)]
    public void IsRightTriangle_ReturnsExpectedResult(double sideA, double sideB, double sideC, bool expectedResult)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        
        Assert.Equal(expectedResult, triangle.IsRightTriangle());
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, 1, 1)]
    [InlineData(10, 2, 7)]
    public void Constructor_ThrowsExceptionForInvalidTriangle(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
}