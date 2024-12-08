public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string Name
    {
        get { return Name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return Description; }
        set { _description = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public void DisplayStartingMsg()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($"\n {_description}");
        Console.WriteLine($"How long in seconds would you like the session to run? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Prepare for Activity.");
        Spinner(5);
    }

    public void DisplayEndingMsg()
    {
        Console.WriteLine("You've successfully completed an activity.");
    }

    public void Spinner(int seconds)
    {
        List<string> loadStr = new List<string>();
        loadStr.Add("|");
        loadStr.Add("/");
        loadStr.Add("-");
        loadStr.Add("\\");
        loadStr.Add("|");
        loadStr.Add("/");
        loadStr.Add("-");
        loadStr.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = loadStr[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= loadStr.Count)
            {
                i = 0;
            }
        }
    }

    public void Countdown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}
