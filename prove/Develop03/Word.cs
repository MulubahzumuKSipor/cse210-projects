class Word
{
    public string Text { get; private set; }
    public bool IsConverted { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsConverted = false;
    }

    public void Hide()
    {
        IsConverted = true;
    }

    public string GetDisplayText()
    {
        return IsConverted ? new string('_', Text.Length) : Text;
    }
}
