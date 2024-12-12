public class Circle : Shape
{
    private double _radius;
    public Circle(string color, int radius) : base(color, "Circle")
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * 3.14;
    }    
}