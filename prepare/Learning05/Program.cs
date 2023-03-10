using System;

class Program
{
    public static List<Shape> myShapes = new List<Shape>();
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Learning05 World!");

        Square s = new Square(5);
        s.GetArea();
        Program.myShapes.Add(s);
        
        Rectangle r = new Rectangle(5, 10);
        r.GetArea();
        Program.myShapes.Add(r);

        Circle c = new Circle(5);
        c.GetArea();
        Program.myShapes.Add(c);
        
    }
}