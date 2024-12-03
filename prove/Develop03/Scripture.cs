class Scripture
{
    private Reference _referenceFromClass;
    private List<Word> _words;

    public Scripture(Reference _reference, string _text)
    {
        _referenceFromClass = _reference;
        _words = new List<Word>();
        foreach (string word in _text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Method to get the reference
    public string GetReference()
    {
        return _referenceFromClass.GetReferenceFromFile();
    }

    // Method to display the scripture with hidden words
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(GetReference());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random _rand = new Random();
        List<int> _availableIndexes = new List<int>();

        // Find all available words that are not hidden
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsConverted)
            {
                _availableIndexes.Add(i);
            }
        }

        if (_availableIndexes.Count >= 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int index = _rand.Next(_availableIndexes.Count);
                _words[_availableIndexes[index]].Hide();
                _availableIndexes.RemoveAt(index);
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsConverted)
                return false;
        }
        return true;
    }
}
