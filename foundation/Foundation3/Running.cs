using System.ComponentModel.DataAnnotations;

public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    //     public override string GetSummary()
    // {
    //     return "";
    // }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance/_length * 60;
    }
    public override double GetPace()
    {
        return _length/_distance;
    }
}