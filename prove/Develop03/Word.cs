using System.Security.Cryptography.X509Certificates;

public class Word{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText(int hideMethod)
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            int wordCnt = _text.Length;
            string firstLetter = _text.Substring(0,1);
            string hiddenWord = "";
            for(int i=0; i< wordCnt; i++)
            {
                if (hideMethod == 2 && i == 0)
                {
                    hiddenWord += firstLetter;
                }
                else
                {
                    hiddenWord += "_";
                }
            }
            return hiddenWord;
        }
    }
}