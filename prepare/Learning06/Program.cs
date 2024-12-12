using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list

        List<Shapes> shapes = new List<Shapes>();

        // Create different kinds of shapes and add them to the same list
        shapes.Add(new Squares("Red", 9));
        shapes.Add(new Rect("Blue", 10, 9));
        shapes.Add(new Circle("Brown", 20));

        // Get a custom calculation for each one
        foreach (Shapes number in shapes)
        {
            Console.WriteLine(
                @$"Color: {number.GetColors()} 
Area: {number.GetArea():F2}
"
            );
        }
    }
}
