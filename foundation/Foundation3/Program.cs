using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> exercises = new List<Activity>
        {
            new Running("2024-12-17", 25, "Running", 15),
            new Cycling("2024-12-17", 30, "Cycling", 10),
            new Swimming("2024-12-17", 15, "Swimming", 10),
        };

        // Iterate through the list and display summaries
        foreach (Activity activities in exercises)
        {
            Console.WriteLine(activities.GetSummary());
        }
    }
}
