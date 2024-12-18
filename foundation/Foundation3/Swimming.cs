public class Swimming: Activity
{
    private int _laps;
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    // public override string GetSummary()
    // {
    //     return $"{_date} ({_length} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile ";
    // }
    public override double GetDistance()
    {
        var distance = (double)_laps * 50/1000*.62 ;
        return distance;
    }
    public override double GetSpeed()
    { 
        var speed = GetDistance()/_length *60 ;
        return speed;
    }
    public override double GetPace()
    {
        var pace = 60/GetSpeed();
        return pace;
    }
}