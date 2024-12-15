public class CheckListGoal : Goal
{
    private int _amountCompleted =0;
    private int _target;
    private int _bonus;
    public CheckListGoal(
        string name, 
        string description, 
        int points,
        int target, 
        int bonus,
        int amountCompleted = 0
        )
        : base(name, description, points)
    {       
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int bonusPoints = 0;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You have reached your target for this goal and earned {_bonus} points");
            bonusPoints = _bonus;
        }
        return GetPoints() + bonusPoints;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string isCompleteString = IsComplete() ? "[X]" : "[ ]";
        return $"{isCompleteString} {GetName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        var description = $"{GoalConstants.CheckListGoalString},{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
        return description;
    }
    public static CheckListGoal CreateCheckListGoalFromFile(string[] stringArray)
    {
        string name=stringArray[1];
        string description=stringArray[2];
        int points = Convert.ToInt32(stringArray[3]);
        int target = Convert.ToInt32(stringArray[4]);
        int bonus = Convert.ToInt32(stringArray[5]);
        int amountCompleted = Convert.ToInt32(stringArray[6]);
        return new CheckListGoal(name, description, points, target, bonus, amountCompleted);
    }
    // public override string GetStringRepresentation()
    // {
    //     return base.GetStringRepresentation();
    // }
}