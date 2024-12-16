public class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine(
                $"{GetName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}."
            );
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Added {_bonus} points for completing '{GetName()}'.");
            }
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return (_amountCompleted >= _target ? "[X] " : "[ ] ")
            + GetName()
            + ""
            + "("
            + GetDescription()
            + ")"
            + "--"
            + GetDetailString();
    }

    public override string GetDetailString()
    {
        return $"Currently completed {_amountCompleted}/{_target}.";
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetTarget()
    {
        return _target;
    }
}
