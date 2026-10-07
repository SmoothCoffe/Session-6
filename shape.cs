namespace Session_6
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public abstract double Area();

    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"(Width = {Width}, Height = {Height})";
        }

    }

    public class Cube : Shape
    {
        public double Depth { get; set; }

        public Cube(double width, double height, double depth) : base(width, height)
        {
            Depth = depth;
        }
        public override double Area()
        {
            return Width * Height * Depth;
        }

        public override string ToString()
        {
            return $"Width = {Width}, Height = {Height}, Depth = {Depth}";
        }
    }
}
