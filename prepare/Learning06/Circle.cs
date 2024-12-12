public class Circle : Shapes
{
    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }

    private double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double _areaCircle = 3.14159 * _radius * _radius;
        return _areaCircle;
    }
}
