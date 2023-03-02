public class Circle : Shape
{
    private int _radius;
    private int _area;
    public Circle(int rad)
    {
        _radius = rad;
    }

    public override void GetArea()
    { 
        _area = 3 * (_radius * _radius);
        Console.WriteLine($"The area is {_area}");
    }
}