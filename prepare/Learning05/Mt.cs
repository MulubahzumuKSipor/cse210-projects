public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, int textBookSection, string problems)
        : base(name, topic)
    {
        _textBookSection = Convert.ToString(textBookSection);
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return @$"{GetSummary()} 
Section {_textBookSection} Problems {_problems}";
    }
}
