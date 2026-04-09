using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();
         // Create list of shapes (polymorphism happens here)
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // Loop through shapes and display info
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}