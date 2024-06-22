namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Triangle : Polygon
    {
        public double Height { get; set; }

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width / 2 * Height;
        }
    }
}
