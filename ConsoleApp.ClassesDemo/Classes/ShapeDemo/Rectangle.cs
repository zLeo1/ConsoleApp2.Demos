using System.Drawing;
using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public double Length { get; set; }

        public Rectangle(double length, double width)
        {
            Width = width;
            Length = length;
        }

        public override double Area()
        {
            return Width * Length;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }
    }
}
