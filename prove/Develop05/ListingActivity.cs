public class ListingActivity : Activity
{
    private int _count=0;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartMessage();
        var prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        ShowCountDown(5);
        Console.WriteLine();
        DateTime endTime = CalculateEndTime();
        while (DateTime.Now < endTime)
        {
            GetPromptItem();
            _count++;
        }
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine();
        DisplayEndMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(_prompts.Length);
        return _prompts[randomNumber];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.Write(prompt);
    }
    private void GetPromptItem()
    {
        Console.ReadLine();
    }
    private void GetListFromUser()
    {
        Console.WriteLine($"You entered {_count} items");
    }

    private string[] _prompts = [
        "Who are people that you appreciate? ..",
        "What are personal strengths of yours? ..",
        "Who are people that you have helped this week? ..",
        "When have you felt the Holy Ghost this month? ..",
        "Who are some of your personal heroes? ..",
        "What are some things that you are proud to have done? ..",
        "What do you most like about yourself? ..",
        "What are some things that you are thankful for? ..",
        "What are some favorite moments from your childhood? ..",
        "Who are some friends that have helped you in your life? .."
    ];
    
}