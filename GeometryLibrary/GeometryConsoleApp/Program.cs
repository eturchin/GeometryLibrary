using GeometryLibrary.Classes;
using GeometryLibrary.Factories;

var circle = ShapeFactory.CreateCircle(5);

Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");

var triangle = ShapeFactory.CreateTriangle(3, 4, 5);

Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");
Console.WriteLine($"Is the triangle right-angled? {(triangle as Triangle)?.IsRightTriangle()}");