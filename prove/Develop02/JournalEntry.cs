public class JournalEntry{
    public JournalEntry(string date, string prompt, string entry)
    {
        if (DateTime.TryParse(date, out var dateTime))
        {
            _date = dateTime;
        }
        else 
        {
            _date = DateTime.Now;
        };
        _prompt = prompt;
        _entry = entry;
        
    }
    public DateTime _date;
    
    public string _prompt;

    public string _entry;

    public string CreateStringEntry()
    {
        return $"{_date:yyyy-MM-dd HH:mm:ss} ~ {_prompt} ~ {_entry}";
    }
}