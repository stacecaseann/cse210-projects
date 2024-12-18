public abstract class Activity
{
    /// <summary>
    /// Date the activity took place
    /// </summary>
    protected DateTime _date;
    /// <summary>
    /// Length of the activity in minutes
    /// </summary>
    protected int _length;
    protected Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;        
    }
    public virtual string GetSummary()
    {
        return $"{_date:dd MMMM yyyy} ({_length} min)- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile ";
    }
    // public abstract string GetSummary();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}