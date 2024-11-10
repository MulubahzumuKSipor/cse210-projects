using System;

class Program
{
    static void Main(string[] args)
    {
        {
        List<int> number = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter whole numbers (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                number.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int total = 0;
        foreach (int numbers in number)
        {
            total += numbers;
        }

        Console.WriteLine($"The total is: {total}");


        float average = ((float)total) / number.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list

        int max = number[0];

        foreach (int numbers in number)
        {
            if (numbers > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = numbers;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
    }
}
