public class WritAssignment : Assignment
{
    private string _title;

    public WritAssignment(string name, string topic, string title)
        : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return @$"{GetSummary()}
{_title}";
    }
}
