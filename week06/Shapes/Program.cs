using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("pink", 2);
        shapes.Add(square1);
                
        Rectangle rectangle1 = new Rectangle("orange", 3, 2);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("turquoise", 4);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }

        Console.WriteLine();
    }
}