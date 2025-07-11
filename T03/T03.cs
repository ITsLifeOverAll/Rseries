using System.Drawing;

var p1 = new Point(0, 0);
var p2 = new Point(4, 0);
var p3 = new Point(0, 3);

var area = CalculateTriangleArea(p1, p2, p3);
Console.WriteLine($"P1: {p1}");
Console.WriteLine($"P2: {p2}");
Console.WriteLine($"P3: {p3}");
Console.WriteLine($"三角形面積: {area}");
return;


double CalculateTriangleArea(Point point1, Point point2, Point point3)
{
    return Math.Abs(
        point1.X * (point2.Y - point3.Y) +
        point2.X * (point3.Y - point1.Y) +
        point3.X * (point1.Y - point2.Y)
    ) / 2.0;
}

