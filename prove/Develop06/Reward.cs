using System.Data;

public class Reward
{
    public string _name;
    public string _description;
    public int _points;

    public Reward(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
        public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public int SpendReward()
    {
        return _points;
    }
    public string GetDetailsString()
    {
        return $"{_name} ({_description}) - {_points} points";
    }
    public string GetStringRepresentation()
    {
        var description = $"Reward,{GetName()},{GetDescription()},{GetPoints()}";
        return description;
    }
    public static Reward CreateRewardFromFile(string[] stringArray)
    {
        string name = stringArray[1];
        string description = stringArray[2];
        int points = Convert.ToInt32(stringArray[3]);
        return new Reward(name, description, points);
    }
}