public class Triangle : Shape
{
    private double _b;
    private double _h;
    public Triangle(string color, int b, int h) : base(color, "Triangle")
    {
        _b = b;
        _h = h;
    }

    public override double GetArea()
    {
        return _b * _h * .5;
    }    
}