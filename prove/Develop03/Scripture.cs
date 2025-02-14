using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private List<Word> _hiddenWordList = new List<Word>(); 
    private Reference _reference;


    public Scripture(Reference words, string reference)
    {
        _reference = words;
        string[] temp = reference.Split(" ");
        foreach (string theCurrentword in temp)
        {
            _words.ToString();
            _words.Add(new Word(theCurrentword));
        }
    }
 
    public void DisplayScripture()
    {
        _reference.DisplayReference();
        bool allWordsHidden = true;
        foreach (Word word in _words)
        {
            if (word._isHidden == true)
            {
                string underscores = new string('_', word.ToString().Length);
                Console.Write($"{underscores} ");
            }
            else
            {
                word.DisplayWords(word.ToString());
                allWordsHidden = false;
            }
        }
        if (!allWordsHidden)
        {
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                if (counter < _words.Count)
                {
                    Word randomWord = RandomWordSelector();
                    randomWord.WordHider();
                    counter += 1;
                }
                else
                {
                    break;
                }
            }
        }
    }

    public Reference ReferenceBypass(Reference reference)
    {
        _reference = reference;
        return _reference;
    }

    public Word RandomWordSelector()
    {
        Random random = new Random();
        int randomNumber = random.Next(_words.Count);
        _words[randomNumber].ToString();

        while (_hiddenWordList.Contains(_words[randomNumber]) & _hiddenWordList.Count < _words.Count)
        {      
            randomNumber = random.Next(_words.Count);
        }
        if (_hiddenWordList.Count < _words.Count)
        {
            _hiddenWordList.Add(_words[randomNumber]);
        }
        return _words[randomNumber];
    }

    public bool AllHiddenChecker()
    {
        bool keepRunning = true;
        if (_hiddenWordList.Count == _words.Count)
        {
            keepRunning = false;
        }
        return keepRunning;
    }
}