public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double time, string type, double speed)
        : base(date, time, type)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetTime()) / 60;
    }
}
