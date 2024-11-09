using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);
        int number = -1;



        while (number != magicNumber)
        {
            Console.Write("What is the magic number? ");
            string word = Console.ReadLine();
            number = int.Parse(word);

            if (number > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (number < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write($"With {magicNumber} being the magic number, You've passed!");
            }


        }
    }
}
