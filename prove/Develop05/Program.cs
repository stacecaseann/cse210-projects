using System;

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