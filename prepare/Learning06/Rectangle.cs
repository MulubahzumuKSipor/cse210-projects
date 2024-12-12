public class Rect : Shapes
{
    public Rect(string color, double width, double length)
        : base(color)
    {
        _length = length;
        _width = width;
    }

    private double _width;
    private double _length;

    public double GetLength()
    {
        return _length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public override double GetArea()
    {
        double _area = _length * _width;
        return _area;
    }
}
