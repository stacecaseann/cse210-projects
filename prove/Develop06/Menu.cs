using System.Dynamic;

public class Menu
{
    protected int _numItems = 0;
    public Menu()
    {
    }

    public virtual void ShowMenu()
    {
    }
    public void SetNumMenuItems(int numItems)
    {
        _numItems = numItems;
    }

    public int GetMenuOption()
    {
        int menuOption = -1;
        while (menuOption < 1 || menuOption > _numItems)
        {
            Console.Write("Please choose an option from the menu. ");
            var menuOptionPicked = Console.ReadLine();
            menuOption = int.TryParse(menuOptionPicked, out var result) ? result : -1;
        }
        return menuOption;
    }

    public virtual void RunMenuOption(int menuOption)
    {
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

}