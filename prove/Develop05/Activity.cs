public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected DateTime _startTime;        
    
    public Activity()
    {
        
    }
    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        bool validNumber = false;
        while (!validNumber)
        {        
            Console.WriteLine("How many seconds would you like to do the activity?");
            var numberString = Console.ReadLine();
            if (int.TryParse(numberString, out var number))
            {
                _duration = number;
                validNumber = true;                
            }
        }      
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.Write("You did such a great job...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.Write($"You did the {_name} for {_duration} seconds...");
        ShowSpinner(5);
        Console.Clear();

    }

    protected void ShowSpinner(int seconds){
        string[] animationArray = ["|", "/","-","\\"];
        //string[] animationArray = [":)", ":O",":(",":O"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i=0;
        while (DateTime.Now < endTime)
        {            
            Console.Write(animationArray[i]);
            Thread.Sleep(1000);
            // Console.Write("\b\b  \b\b");
            Console.Write("\b \b");
            i++;
            if (i==4)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i=seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected DateTime CalculateEndTime()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        return endTime;
    }
}