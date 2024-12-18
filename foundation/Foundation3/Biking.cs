using System.ComponentModel.DataAnnotations;

public class Biking : Activity
{
    private double _speed;
    public Biking(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    // public override string GetSummary()
    // {
    //     return "";
    // }
    public override double GetDistance()
    {
        return _speed * _length/60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        var pace = _length/GetDistance();
        return pace;
    }
}