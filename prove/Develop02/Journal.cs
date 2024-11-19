using System.Text;

public class Journal
{
    public List<JournalEntry> _journalEntries = new();

    public string CreateEntriesString()
    {
        StringBuilder builder = new StringBuilder();
        foreach (var journalEntry in _journalEntries)
        {
            builder.AppendLine(journalEntry.CreateStringEntry());//TODO test that this isn't the same that writes to the console
            builder.AppendLine();
        }
        return builder.ToString();
    }

    public void DisplayEntries()
    {
        string entriesString = CreateEntriesString();
        if (entriesString == "")
        {
            Console.WriteLine("No journal entries yet");
        }
        else 
        {
            Console.WriteLine(entriesString);
        }
    }
    public void SaveEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new (fileName))
        {
            outputFile.WriteLine(CreateEntriesString());
        }
    }
    public void LoadFromFile(string fileName)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            List<JournalEntry> journalEntries = [];
            foreach(string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    //TODO need to parse date and journal entry and prompt
                    string[] entry = line.Split("~");
                    string date = entry[0].Trim();
                    string prompt = entry[1].Trim();
                    string text = entry[2].Trim();
                    JournalEntry journalEntry = new(date, prompt, text);
                    journalEntries.Add(journalEntry);
                }
            }
            _journalEntries = journalEntries;
            DisplayEntries();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Could not load file: {e.Message}");
        }
    }
}