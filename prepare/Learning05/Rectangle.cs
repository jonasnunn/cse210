public class Rectangle : Shape
{
    private int _side1;
    private int _side2;
    private int _area;

    public Rectangle(int side1, int side2)
    {
        _side1 = side1;
        _side2 = side2;
    }

    public override void GetArea()
    { 
        _area = _side1 * _side2;
        Console.WriteLine($"The area is {_area}");
    }

}