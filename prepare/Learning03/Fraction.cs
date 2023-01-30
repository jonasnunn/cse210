public class Fraction
{
    private int _topNum;
    private int _botNum; 
    public Fraction()
    {
        _topNum = 1;
        _botNum = 1;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }
    public Fraction(int top)
    {
        _topNum = top;
        _botNum = 1;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }
    public Fraction(int top, int bottom){
        _topNum = top;
        _botNum = bottom;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }
    private string GetFractionString(){
        return $"{_topNum}/{_botNum}";
    }
    private double GetDecimalValue(){
        return (double)_topNum / _botNum;
    }
}