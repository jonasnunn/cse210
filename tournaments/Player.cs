public class Player
{
    private string _name;
    private int _jNumber;     

    public Player(string name, int jersey)
    {
        _name = name;
        _jNumber = jersey;
    }

    public void display()
    {
        Console.WriteLine($"{_name} {_jNumber}");
    }
}