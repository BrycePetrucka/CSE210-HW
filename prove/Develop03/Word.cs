using System.Diagnostics.Metrics;

public class Word
{
    private string _currentWord;
    public bool _isHidden;

    public override string ToString()
    {
        return _currentWord;
    }

    public Word(string currentWord)
    {
        _currentWord = currentWord;
        _isHidden = false;
    }

    public bool WordHider()
    {
        if (_isHidden == false)
        {
            _isHidden = true;
        }
        return _isHidden;
    }
    
    public void DisplayWords(string word)
    {
        Console.Write($"{word} ");
    }
}

