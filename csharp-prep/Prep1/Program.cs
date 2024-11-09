using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First name? ");
        String name = Console.ReadLine();
        Console.Write("What is your Last name? ");
        String lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}");
    }
}
