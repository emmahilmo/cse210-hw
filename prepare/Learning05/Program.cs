using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("yellow", 2);
        shapes.Add(s1);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());

        Rectangle s2 = new Rectangle("Purple", 3, 2);
        shapes.Add(s2);
        // Console.WriteLine(s2.GetColor());
        // Console.WriteLine(s2.GetArea());

        Circle s3 = new Circle("Blue", 2);
        shapes.Add(s3);
        // Console.WriteLine(s3.GetColor());
        // Console.WriteLine(s3.GetArea());

        foreach(Shape s in shapes) {
            string color = s.GetColor();
            double area = s.GetArea();
        
            Console.WriteLine($"The {color} shape has the area of {area}.");
        }
    }
}