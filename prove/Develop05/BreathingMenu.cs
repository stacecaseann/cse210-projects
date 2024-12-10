public class BreathingMenu : Menu
{
    private readonly BreathingActivity _breathingActivity;

    public BreathingMenu(BreathingActivity breathingActivity) : base(4)
    {
        _breathingActivity = breathingActivity;
    }
    public override void ShowMenu()
    {
        Console.WriteLine("1: Triangle Breathing");
        Console.WriteLine("2: Box Breathing");
        Console.WriteLine("3: 4-7-8 Breathing");
        Console.WriteLine("4: Breathe In and Out");
    }

    public override void RunMenuOption(int menuOption)
    {
        switch (menuOption)
        {
            case 1:
                _breathingActivity.RunActivity(_breathingActivity.RunTriangleBreathing);
                break;
            case 2:
                _breathingActivity.RunActivity(_breathingActivity.RunBoxBreathing);
                break;
            case 3:
                _breathingActivity.RunActivity(_breathingActivity.Run478Breathing);
                break;
            case 4:
                _breathingActivity.RunActivity(_breathingActivity.RunBreatheInAndOut);
                break;
            default:
                _breathingActivity.RunActivity(_breathingActivity.RunBreatheInAndOut);
                break;
        }
    }
}