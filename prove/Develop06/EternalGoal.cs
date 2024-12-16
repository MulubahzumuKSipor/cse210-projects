public class Eternal : Goal
{
    public Eternal(string name, string description, string points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "[ ] " + GetName() + "(" + GetDescription() + ")";
    }
}
