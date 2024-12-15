public class EternalGoal : Goal
{
    private int _numTimesCompleted = 0;
    public EternalGoal(string name, string description, int points, int numTimesCompleted = 0)
        : base(name, description, points)
    {        
        _numTimesCompleted = numTimesCompleted;
    }

    public override int RecordEvent()
    {
        _numTimesCompleted++;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        string isCompleteString = IsComplete() ? "[X]" : "[ ]";
        return $"{isCompleteString} {GetName()} ({GetDescription()}) - Completed {_numTimesCompleted} times";
    }
    public override string GetStringRepresentation()
    {
        var description = $"{GoalConstants.EternalGoalString},{GetName()},{GetDescription()},{GetPoints()},{_numTimesCompleted}";
        return description;
    }

    public static EternalGoal CreateEternalGoalFromFile(string[] stringArray)
    {
        string name=stringArray[1];
        string description=stringArray[2];
        int points = Convert.ToInt32(stringArray[3]);
        int numTimesCompleted = Convert.ToInt32(stringArray[4]);
        return new EternalGoal(name, description, points, numTimesCompleted);
    }
}