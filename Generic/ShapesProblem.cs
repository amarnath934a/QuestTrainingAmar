using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IShapes
{
    void GetArea();
    void GetPerimeter();
}
class Circle : IShapes
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void GetArea() => Console.WriteLine($"Circle area: {Math.PI * Radius * Radius}");

    public void GetPerimeter() => Console.WriteLine($"Circle perimeter: {2 * Math.PI * Radius}");
}

class Rectangle : IShapes
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public void GetArea() => Console.WriteLine($"Rectangle area: {Length * Width}");

    public void GetPerimeter() => Console.WriteLine($"Rectangle perimeter: {2 * (Length + Width)}");
}

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<IShapes>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };
        foreach (var shape in shapes)
        {
            shape.GetArea();
            shape.GetPerimeter();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
