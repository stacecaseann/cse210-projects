
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = BreakupTextIntoWords(text);
    }

    private List<Word> BreakupTextIntoWords(string text)
    {
        List<Word> wordList = new List<Word>();
        string[] words = text.Split(" ");
        foreach (var word in words)
        {
            wordList.Add(new Word(word));
        }
        return wordList;
    }

    public bool HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for(int i=0; i < numberToHide; i++)
        {
            var wordsStillShown = _words.Where(x => !x.IsHidden()).ToList();
            if (wordsStillShown.Count() == 0)
            {
                return true;
            }
            int randomIndex = random.Next(wordsStillShown.Count());
            wordsStillShown[randomIndex].Hide();
        }
        return false;
    }
    public string GetDisplayText(int hideMethod)
    {
        string displayText = "";
        int i=0;
        foreach (var word in _words)
        {
            if (i != 0)
            {
                displayText += " ";
            }
            displayText += word.GetDisplayText(hideMethod);
            i++;
        }
        return $"{_reference.GetDisplayText()} - {displayText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}