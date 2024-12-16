public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string point)
    {
        _shortName = name;
        _description = description;
        _points = point;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailString()
    {
        return "";
    }
}
