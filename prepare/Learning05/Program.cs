using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square test1 = new Square("blue", 4);
        shapes.Add(test1);

        Rectangle test2 = new Rectangle("red", 4, 2);
        shapes.Add(test2);
        
        Circle test3 = new Circle("green", 6);
        shapes.Add(test3);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();


            Console.WriteLine($"Color: {color} - Shape area: {area}");


        }
    }
}