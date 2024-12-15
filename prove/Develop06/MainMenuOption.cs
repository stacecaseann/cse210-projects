public class MainMenuOption
{
    private int _index;
    private string _description;
    private Action _action;

    public MainMenuOption(int index, string description, Action action)
    {
        _index = index;
        _description = description;
        _action = action;
    }

    public int GetIndex()
    {
        return _index;
    }
    public string GetDescription()
    {
        return _description;
    }
    public Action GetAction()
    {
        return _action;
    }
}