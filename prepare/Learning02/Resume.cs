
using System;

public class Resume
{
    public string name = "";

    public List<Jobs> _jobs = new List<Jobs>();


    public void DisplayResume()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Jobs: ");

        foreach (Jobs job in _jobs)
        {

            job.DisplayJobs();
        }
    }

}