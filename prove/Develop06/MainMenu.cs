public class MainMenu : Menu
{
    private readonly GoalManager _goalManager;
    private List<MainMenuOption> _menuOptions;
    public MainMenu(GoalManager goalManager)
    {
        _goalManager = goalManager;
        
        _menuOptions = new()
        {
            { new(1,"Create New Goal", _goalManager.CreateGoal)},
            { new(2,"List Goals", _goalManager.ListGoalDetails)},
            { new(3,"Record Event", _goalManager.RecordEvent)},
            { new(4,"Setup Rewards", _goalManager.SetupRewards)},
            { new(5,"View Rewards", _goalManager.ViewRewards)},
            { new(6,"Spend Rewards", _goalManager.SpendRewards)},
            { new(7,"Save Goals", _goalManager.SaveGoals)},
            { new(8,"Load Goals", _goalManager.LoadGoals)},
            { new(9,"Save Goals To Default File", _goalManager.SaveGoalsToDefaultFile)},
            { new(10,"Load Goals From Default File", _goalManager.LoadGoalsFromDefaultFile)},
            { new(11,"Quit", () => Quit())}
        };
        SetNumMenuItems(_menuOptions.Count());
    }

    public override void ShowMenu()
    {
        _goalManager.DisplayPlayerInfo();
        foreach (var menuOption in _menuOptions)
        {
            Console.WriteLine($"{menuOption.GetIndex()}: {menuOption.GetDescription()}");
        }
    }

    public override void RunMenuOption(int menuOptionIndex)
    {
        var menuOption = _menuOptions.Where(x => x.GetIndex() == menuOptionIndex).FirstOrDefault();
        if (menuOption != null)
        {
            var action = menuOption.GetAction();
            action.Invoke();
        }
    }

    private void Quit()
    {
        Environment.Exit(0);   //0 means success
    }

}