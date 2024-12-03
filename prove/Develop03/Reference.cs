class Reference
{
    private string _referenceFromFile;

    public Reference(string reference)
    {
        _referenceFromFile = reference;
    }

    public Reference(string book, int startChapter, int startVerse, int endChapter, int endVerse)
    {
        _referenceFromFile = $"{book} {startChapter}:{startVerse}-{endChapter}:{endVerse}";
    }

    public string GetReferenceFromFile()
    {
        return _referenceFromFile;
    }
}
