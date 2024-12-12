public class Squares : Shapes
{
    public Squares(string color, double sides)
        : base(color)
    {
        _sides = sides;
    }

    private double _sides = 0;

    public double GetSide()
    {
        return _sides;
    }

    public void SetSide(double side)
    {
        _sides = side;
    }

    public override double GetArea()
    {
        double sides = _sides * _sides;
        return sides;
    }
}
