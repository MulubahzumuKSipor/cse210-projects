using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Course grade in numbers? ");
        string score = Console.ReadLine();
        int finalScore = int.Parse(score);
        if (finalScore >= 93)
        {
            Console.WriteLine("A");
        }
        else if (finalScore >= 90)
        {
            Console.WriteLine("A-");
        }
        else if (finalScore >= 84)
        {
            Console.WriteLine("B+");
        }
        else if (finalScore >= 80)
        {
            Console.WriteLine("B-");
        }
        else if (finalScore >= 74)
        {
            Console.WriteLine("C+");
        }
        else if (finalScore >= 70)
        {
            Console.WriteLine("C-");
        }
        else if (finalScore >= 64)
        {
            Console.WriteLine("D+");
        }
        else if (finalScore >= 60)
        {
            Console.WriteLine("D-");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
