using System.Globalization;
using System.Runtime.Serialization;

public class Menu
{
    Journal _journal = new();

    public int DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("1. Write entry");
        Console.WriteLine("2. Display entry");
        Console.WriteLine("3. Load file");
        Console.WriteLine("4. Save file");
        Console.WriteLine("5. Quit");
        Console.WriteLine("");
        Console.Write("What option do you choose? ");
        
        bool optionValid = false;
        int option = -1;
        while (!optionValid)
        {
            string optionString = Console.ReadLine();
            if (!int.TryParse(optionString, out option) && option >= 0 && option <=5)
            {
                Console.WriteLine("Please enter an option between 1 and 5");
            }
            else
            {
                optionValid = true;
            }
        }
        return option;
    }

    public int RunMenu()
    {
        int option = DisplayMenu();
        switch(option)
        {
            case 1: 
                CreateJournalEntry();
                break;
            case 2: 
                DisplayJournal();
                break;
            case 3: 
                LoadJournal();
                break;
            case 4:
                SaveJournal();
                break;
            case 5:
                Quit();
                break;
            default:
                CreateJournalEntry();
                break;
        }
        return option;
    }

    public void CreateJournalEntry()
    {
        PromptCreator promptCreator = new PromptCreator();
        string prompt = promptCreator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("");
        var entry = Console.ReadLine();
        
        JournalEntry journalEntry = new JournalEntry(
            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            prompt,
            entry);
       _journal.SaveEntry(journalEntry);
    }

    public void DisplayJournal()
    {
        _journal.DisplayEntries();
    }

    public void LoadJournal()
    {
        Console.WriteLine("What journal file would you like to load?");
        string fileName = Console.ReadLine();

        _journal.LoadFromFile(fileName);//TODO test that this loads it

    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the fileName?");
        string fileName = Console.ReadLine();
        _journal.SaveToFile(fileName);

    }

    public void Quit()
    {
        Environment.Exit(0);   //0 means success
    }
}