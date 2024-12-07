using System;

class Program
{
    static void Main(string[] args)
    {
        var writAssignment = new WritAssignment(
            "Alice",
            "European History",
            "The Causes of World War II by Mary Waters"
        );
        Console.WriteLine(writAssignment.GetWritingInfo());

        var mathAssignment = new MathAssignment("Alice", "Calculus", 9, "3-12");
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}
