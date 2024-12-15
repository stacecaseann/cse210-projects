public class CreateGoalMenu : Menu
{
    private readonly GoalManager _goalManager;

    public CreateGoalMenu(GoalManager goalManager)
    {
        _goalManager = goalManager;
        SetNumMenuItems(3);
    }

    public override void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");

        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: CheckList Goal");
    }

    public override void RunMenuOption(int menuOption)
    {
        switch (menuOption)
        {
            case 1:
                CreateSimpleGoal();
                break;
            case 2:
                CreateEternalGoal();
                break;
            case 3:
                CreateCheckListGoal();
                break;
            default:
                CreateSimpleGoal();
                break;
        }
    }

    private void CreateCheckListGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        int points = GetIntInput("What are the amount of points associated with this goal? ");
        int target = GetIntInput("How many times would you like to do this goal before getting a bonus? ");
        int bonusPoints = GetIntInput($"What is the bonus for completing it {target} times? ");

        CheckListGoal goal = new CheckListGoal(name, description, points, target, bonusPoints);
        _goalManager.AddGoal(goal);
    }

    private void CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        int points = GetIntInput("What are the amount of points associated with this goal? ");

        EternalGoal goal = new EternalGoal(name, description, points);
        _goalManager.AddGoal(goal);
    }

    private void CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        int points = GetIntInput("What are the amount of points associated with this goal? ");

        SimpleGoal goal = new SimpleGoal(name, description, points);
        _goalManager.AddGoal(goal);
    }



}