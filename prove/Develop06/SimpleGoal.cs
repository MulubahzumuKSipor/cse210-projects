using System.Drawing;

public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, string points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
    }

    public override bool IsComplete()
    {
        return _isComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return (_isComplete ? "[X] " : "[ ] ") + GetName() + "(" + GetDescription() + ")";
    }
}
