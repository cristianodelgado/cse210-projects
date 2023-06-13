using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square sq = new Square("Green", 8);
        shapes.Add(sq);

        Rectangle re = new Rectangle("pink",2, 4);
        shapes.Add(re);

        Circle ci = new Circle("gray",5);
        shapes.Add(ci);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine("The area of the shape "+ color + " is: " + area);
        }
    }
}