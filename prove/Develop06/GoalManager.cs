
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

public class GoalManager
{
    private List<Goal> _goals = [];
    private List<Reward> _rewards = [];
    private int _score = 0;
    private int _totalGoals = 0;

    private string _defaultFileName = "goals.txt";

    public GoalManager()
    {
        
    }

    public Action GoalAction {get; set;}
    public void Start()
    {
        bool run = true;
        while(run)
        {
            MainMenu menu = new MainMenu(this);
            menu.ShowMenu();
            var menuItem = menu.GetMenuOption();
            menu.RunMenuOption(menuItem);
            Console.WriteLine();
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    /// <summary>
    /// List Names to be picked when recording a goal
    /// </summary>
    public Dictionary<int, string> ListGoalNames()
    {
        Dictionary<int, string> goalNames = [];
        int i=1;
        foreach(var goal in _goals)//.Where(x => !x.IsComplete()))
        {
            goalNames.Add(i, goal.GetName());
            i++;
        }
        return goalNames;
    }

    public void ListGoalDetails()
    {
        if (!_goals.Any())
            Console.WriteLine("You don't have any goals yet");
        else
            _goals.ForEach(x => Console.WriteLine(x.GetDetailsString()));
    }
    public void CreateGoal()
    {
        CreateGoalMenu menu = new CreateGoalMenu(this);
        menu.ShowMenu();
        var menuItem = menu.GetMenuOption();
        menu.RunMenuOption(menuItem);
    }

    public void RecordEvent()
    {
        if (_goals.Count() == 0)
        {
            Console.WriteLine($"You have no goals yet."); 
        }
        else
        {
            var goalNames = ListGoalNames();
            foreach (var goal in goalNames)
            {
                Console.WriteLine($"{goal.Key}. {goal.Value}");            
            }
            Console.WriteLine();
            int goalPicked = -1;
            while(goalPicked == -1 || goalPicked > goalNames.Count())
            {
                Console.Write("Which goal did you accomplish? ");
                var stringGoal = Console.ReadLine();
                goalPicked = int.TryParse(stringGoal, out var result) ? result : -1;
            }
            var goalItem = _goals.Where(x => x.GetName() == goalNames[goalPicked]).FirstOrDefault();
            if (goalItem != null)
            {
                int score = goalItem.RecordEvent();
                _score += score;
                _totalGoals++;
                CheckTotalGoals();
            }
        }
    }

    private void CheckTotalGoals()
    {
        
        if (_totalGoals%100==0)
        {
            _score+=1000;
            PrintAwardAnimation();
            Console.WriteLine($"You get a 1000 point goal bonus for completing {_totalGoals} goals!!!");
        }
        else if (_totalGoals%50==0)
        {
            _score+=500;
            PrintAwardAnimation();
            Console.WriteLine($"You get a 500 point goal bonus for completing {_totalGoals} goals!!!");
        }
        else if (_totalGoals%10==0)
        {
            _score+=100;
            PrintAwardAnimation();
            Console.WriteLine($"You get a 100 point goal bonus for completing {_totalGoals} goals!!!");
        }
    }

    private void PrintAwardAnimation()
    {
        Animation.ShowAnimation();
    }

    #region SaveGoals
    public void SaveGoals()
    {
        Console.Write("What is the name of your file? ");
        string fileName = Console.ReadLine();
        SaveGoalsInternal(fileName);
    }

    public void SaveGoalsToDefaultFile()
    {
        SaveGoalsInternal(_defaultFileName);
    }

    private void SaveGoalsInternal(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_totalGoals);
            foreach (var goal in _goals)
            {                
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            foreach(var reward in _rewards)
            {
                outputFile.WriteLine(reward.GetStringRepresentation());
            }
        }
    }
    #endregion
    #region LoadGoals
    public void LoadGoals()
    {
        Console.Write("What is the name of your file? ");
        string fileName = Console.ReadLine();
        LoadGoalsInternal(fileName);
    }
    public void LoadGoalsFromDefaultFile()
    {
        LoadGoalsInternal(_defaultFileName);
    }

    private void LoadGoalsInternal(string fileName)
    {
        try{
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _goals = [];
            _rewards = [];
            int lineNum = 0;
            foreach(string line in lines)
            {
                if (lineNum == 0)
                {
                    _score = int.Parse(line);
                }
                else if (lineNum == 1)
                {
                    _totalGoals = int.Parse(line);
                }
                else
                {
                    string[] items = line.Split(",");
                    string type = items[0];
                    if (type == GoalConstants.EternalGoalString)
                    {
                        var eternalGoal = EternalGoal.CreateEternalGoalFromFile(items);
                        _goals.Add(eternalGoal);
                    }
                    else if (type == GoalConstants.SimpleGoalString)
                    {
                        var simpleGoal = SimpleGoal.CreateSimpleGoalFromFile(items);
                        _goals.Add(simpleGoal);
                    }
                    else if (type == GoalConstants.CheckListGoalString)
                    {
                        var checkListGoal = CheckListGoal.CreateCheckListGoalFromFile(items);
                        _goals.Add(checkListGoal);
                    }
                    else if (type == GoalConstants.RewardString)
                    {
                        var reward = Reward.CreateRewardFromFile(items);
                        _rewards.Add(reward);
                    }
                }
                lineNum++;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine($"The file does not exist {e.Message}");
        }
        
    }
    #endregion
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    #region Rewards
    public void SetupRewards()
    {
        Console.Write("What is the name of your reward? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        int points = GetIntInput("What are the amount of points associated with this goal? ");

        Reward reward = new Reward(name, description, points);
        _rewards.Add(reward);
    }
    public void ViewRewards()
    {
        Console.WriteLine();
        Console.WriteLine("REWARDS");
        if (_rewards.Count == 0)
        {
            Console.WriteLine("You have no rewards set up");
        }
        else
        {
            foreach (var reward in _rewards)
            {
                Console.WriteLine(reward.GetDetailsString());
            }
        }
    }
    public void SpendRewards()
    {
        Console.WriteLine();
        if (_rewards.Count == 0)
        {
            Console.WriteLine("You have no rewards set up");
        }
        else
        {
            var rewardNames = ListRewardNames();
            foreach (var reward in rewardNames)
            {
                Console.WriteLine($"{reward.Key}. {reward.Value}");            
            }
            Console.WriteLine();
            int rewardPicked = -1;
            while(rewardPicked == -1 || rewardPicked > rewardNames.Count())
            {
                Console.Write("Which reward would you like to spend? ");
                var stringReward = Console.ReadLine();
                rewardPicked = int.TryParse(stringReward, out var result) ? result : -1;
            }
            var rewardItem = _rewards.Where(x => x.GetName() == rewardNames[rewardPicked]).FirstOrDefault();
            if (rewardItem != null)
            {
                int score = rewardItem.SpendReward();
                if (score > _score)
                {
                    Console.WriteLine("You don't enough points to spend this reward!");
                }
                else
                {
                    _score -= score;
                    if (score < 0)
                    {
                        score = 0;
                    }
                }
            }
        }
    }
    private Dictionary<int, string> ListRewardNames()
    {
        Dictionary<int, string> rewardNames = [];
        int i=1;
        foreach(var reward in _rewards)
        {
            rewardNames.Add(i, $"{reward.GetName()}");
            i++;
        }
        return rewardNames;
    }

    protected int GetIntInput(string message)
    {
        bool validNumber = false;
        int intInput = -1;
        while (!validNumber)
        {
            Console.Write(message);
            string stringInput = Console.ReadLine();
            if (int.TryParse(stringInput, out intInput))
            {
                validNumber = true;
            }
        }
        return intInput;
    }
    #endregion



}