public class Listing : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public Listing(string name, string description, int time)
        : base(name, description, time)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Name = "Listing";
        Description =
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        DisplayStartingMsg();
        GetRandomPrompt();
        GetListFromUser();
        Thread.Sleep(2000);
        DisplayEndingMsg();
        Thread.Sleep(1000);
    }

    public void GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        string _displayRandomPrompt = _prompts[randomPrompt.Next(_prompts.Count)];

        Console.WriteLine(_displayRandomPrompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            list.Add(input);
            _count++;
        }

        list.Add($"{_count}");
        Console.WriteLine($"You gave: {list.Count - 1} responses");

        return list;
    }
}
