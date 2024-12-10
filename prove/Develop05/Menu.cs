public class Menu
{
    protected int _numItems;
    public Menu(int numItems)
    {
        _numItems = numItems;
    }

    public virtual void ShowMenu()
    {
    }

    public int GetMenuOption()
    {
        int menuOption = -1;
        while (menuOption < 1 || menuOption > _numItems)
        {
            Console.WriteLine("Please choose an option from the menu. ");
            var menuOptionPicked = Console.ReadLine();
            menuOption = int.TryParse(menuOptionPicked, out var result) ? result : -1;
        }
        return menuOption;
    }

    public virtual void RunMenuOption(int menuOption)
    {
    }


}