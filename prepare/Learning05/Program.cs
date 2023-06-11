using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("green", 6, 8);
        Circle circle = new Circle("blue", 4);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {Math.Round(area, 1)}.");
        }
    }
}