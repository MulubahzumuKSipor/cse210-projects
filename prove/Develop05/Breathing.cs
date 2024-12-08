public class Breathing : Activity
{
    public Breathing(string name, string description, int time)
        : base(name, description, time) { }

    public void Run()
    {
        Name = "Breathing";
        Description =
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind of all distractions and focus only on breathing.";

        DisplayStartingMsg();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Breath in");
            Countdown(3);
            Console.WriteLine("Breath out");
            Countdown(2);
        }
        Console.Clear();
        DisplayEndingMsg();
    }
}
