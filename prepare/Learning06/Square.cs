public class Square : Shape
{
    private double _side;
    public Square(string color, int side) : base(color, "Square")
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }    
}