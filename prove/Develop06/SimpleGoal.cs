public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {        
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        var description = $"{GoalConstants.SimpleGoalString},{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
        return description;
    }
    public static SimpleGoal CreateSimpleGoalFromFile(string[] stringArray)
    {
        string name=stringArray[1];
        string description=stringArray[2];
        int points = Convert.ToInt32(stringArray[3]);
        bool isComplete = Convert.ToBoolean(stringArray[4]);
        return new SimpleGoal(name, description, points, isComplete);
    }

}