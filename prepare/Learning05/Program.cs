using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("purple", 4));
        shapes.Add(new Rectangle("blue", 5, 6));
        shapes.Add(new Circle("red", 4));

        foreach(Shape thingy in shapes)
        {
            Console.WriteLine(thingy.GetColor());
            Console.WriteLine(thingy.GetArea());
        }


        // Console.WriteLine("Square");
        // Square sq = new Square("purple", 4);
        // Console.WriteLine(sq.GetColor());
        // Console.WriteLine(sq.GetArea());

        // Console.WriteLine("\nRectangle");
        // Rectangle rec = new Rectangle("blue", 5, 6);
        // Console.WriteLine(rec.GetColor());
        // Console.WriteLine(rec.GetArea());

        // Console.WriteLine("\nCircle");
        // Circle cir = new Circle("red", 4);
        // Console.WriteLine(cir.GetColor());
        // Console.WriteLine(cir.GetArea());

    }
}