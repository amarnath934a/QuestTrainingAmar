using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    abstract class Shape
    {
        public abstract double Area();
    }
    class Circle : Shape
    {
        public int radius;
        private const double Pi = 3.141;
        public Circle(int radius) => this.radius = radius;
        public override double Area() => Pi * radius * radius;

    }

    class Rectangle : Shape
    {
        public int Length;
        public int Width;
        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }
        public override double Area() => Length * Width;
    }

    class program
    {
        static void Main()
        {
            Shape circle = new Circle(8);
            Console.WriteLine("Area of circle is: " + circle.Area());
            Shape rectangle = new Rectangle(20, 8);
            Console.WriteLine("Area of Rectangle is: " + rectangle.Area());
            Console.ReadLine();
        }
    }

}
