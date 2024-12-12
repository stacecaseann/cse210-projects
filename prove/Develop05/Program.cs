/*
EXCEEDS REQUIREMENTS
To do a little extra, I created 4 activities within the Breathing Exercises with different ways to breathe in and out. The user can pick which activity they want to do. 
In the Reflecting Activity, I give the user a random question and don't repeat the questions unless they go through all the questions in the timeframe that they picked. 

*/

class Program
{
    static void Main(string[] args)
    {
        //TODO does this need to be a loop
        bool continueRunning = true;
        while (continueRunning)
        {
            var menu = new MainMenu();
            menu.ShowMenu();
            var menuItem = menu.GetMenuOption();
            menu.RunMenuOption(menuItem);
        }
    }
}