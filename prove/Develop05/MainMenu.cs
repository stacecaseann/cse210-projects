public class MainMenu : Menu
{
    public MainMenu() : base(4)
    {
    }
    public override void ShowMenu()
    {
        Console.WriteLine("1: Breathing Activity");
        Console.WriteLine("2: Reflection Activity");
        Console.WriteLine("3: Listing Activity");
        Console.WriteLine("4. Quit");
    }

    public override void RunMenuOption(int menuOption)
    {
        switch (menuOption)
        {
            case 1:
                RunBreathingActivity();
                break;
            case 2:
                RunReflectionActivity();
                break;
            case 3:
                RunListingActivity();
                break;
            case 4:
                Quit();
                break;
            default:
                Quit();
                break;
        }
    }

    private void RunListingActivity()
    {
        var listingActivity = new ListingActivity();
        listingActivity.Run();
    }

    private void RunReflectionActivity()
    {
        var reflectionActivity = new ReflectingActivity();
        reflectionActivity.Run();
    }

    private void RunBreathingActivity()
    {
        var breathingActivity = new BreathingActivity();
        breathingActivity.Run();
    }

    private void Quit()
    {
        Environment.Exit(0);   //0 means success
    }
}