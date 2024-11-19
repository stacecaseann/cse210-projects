using System;

class Program
{
    static void Main(string[] args)
    {       
        Menu menu = new();
        int menuItem;
        do
        {
            menuItem = menu.RunMenu();
        } while (menuItem != 5);
    }
}