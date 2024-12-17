public abstract class Activity
{
    private string _date;
    private double _timed;
    private string _type;

    public Activity(string date, double time, string type)
    {
        _date = date;
        _timed = time;
        _type = type;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetTime()
    {
        return _timed;
    }

    public string GetType()
    {
        return _type;
    }

    public abstract double GetSpeed();

    public abstract double GetDistance();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return (
            $"{GetDate()} {GetType()}({GetTime()}) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile"
        );
    }
}
