public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double time, string type, double laps)
        : base(date, time, type)
    {
        _laps = laps;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetTime() * 60;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
}
