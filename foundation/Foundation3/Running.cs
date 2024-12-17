public class Running : Activity
{
    private double _distance;

    public Running(string date, double time, string type, double distance)
        : base(date, time, type)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetTime() / _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetTime()) * 60;
    }
}
