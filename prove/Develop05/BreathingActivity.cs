public class BreathingActivity : Activity
{
     public BreathingActivity() 
     {
          _name = "Breathing Activity";
          _description = "This activity will help you relax by walking you through a breathing activity. Clear your mind and focus on your breathing.";
     }
     public void Run()
     {
          DisplayStartMessage();
          var breathingMenu = new BreathingMenu(this);
          breathingMenu.ShowMenu();
          int activity = breathingMenu.GetMenuOption();
          breathingMenu.RunMenuOption(activity);     
          DisplayEndMessage();
     }

     internal void RunActivity(Action<DateTime> action)
     {
          DateTime endTime = CalculateEndTime();
          // Console.WriteLine($"{startTime} to {endTime}");
          action(endTime);
     }
     internal void RunTriangleBreathing(DateTime endTime)
     {       
          BreathingItem[] messages = 
          [
               new ("Breathe in for 3 seconds...",3),
               new("Hold your breath for 3 seconds...",3),
               new("Breathe out for 3 seconds...",3)
          ];
          Breathe(messages, endTime);
     }

     internal void RunBoxBreathing(DateTime endTime)
     {
          BreathingItem[] messages = 
          [
               new("Breathe in for 4 seconds...",4),
               new("Hold your breath for 4 seconds...",4),
               new("Breathe out for 4 seconds...",4),
               new("Hold your breath for 4 seconds...",4)
          ];
          Breathe(messages, endTime);
     }

     internal void Run478Breathing(DateTime endTime)
     {
          BreathingItem[] messages = 
          [
               new("Breathe in for 4 seconds...",4),
               new("Hold your breath for 7 seconds...",7),
               new("Breathe out for 8 seconds...",8)
          ];
          Breathe(messages, endTime);
     }

     internal void RunBreatheInAndOut(DateTime endTime)
     {
          BreathingItem[] messages = 
          [
               new("Breathe in...",5),
               new("Breathe out...",5)
          ];
          Breathe(messages, endTime);
     }
     
     private void Breathe(BreathingItem[] messages, DateTime endTime)
     {
          int i=0;
          while (DateTime.Now < endTime)
          {   
               var breathingItem = messages[i];
               Console.Write(breathingItem.Message);
               ShowCountDown(breathingItem.Seconds);
               Console.WriteLine();
               i++;
               if (i == messages.Length)
               {
                    i=0;
               }
          }
     }

    private class BreathingItem(
         string message,
         int seconds
    )
    {
        public string Message { get; } = message;
        public int Seconds { get; } = seconds;
    }
}