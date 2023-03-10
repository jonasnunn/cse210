public class Square : Shape
{
    private int _side1;
    private int _area;
    public Square(int side)
    {
        _side1 = side;
    }

    public override void GetArea()
    { 
        _area = _side1 * _side1;
        Console.WriteLine($"The area is {_area}");
    }
}