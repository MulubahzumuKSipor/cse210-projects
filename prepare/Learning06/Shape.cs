public abstract class Shapes
{
    private string _colors = "";

    public Shapes(string colors)
    {
        _colors = colors;
    }

    public string GetColors()
    {
        return _colors;
    }

    public void SetColors(string colors)
    {
        _colors = colors;
    }

    public abstract double GetArea();
}
