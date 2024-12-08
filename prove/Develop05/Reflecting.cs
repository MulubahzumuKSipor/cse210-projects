public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflecting(string name, string description, int time)
        : base(name, description, time)
    {
        //Prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        //Questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add(
            "What made this time different than other times when you were not as successful?"
        );
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add(
            "What could you learn from this experience that applies to other situations?"
        );
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        Name = "Reflecting";
        Description =
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        DisplayStartingMsg();
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            DisplayPrompt();
            Thread.Sleep(2000);
            DisplayQuestion();
            Spinner(10);
        }
    }

    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        string _displayRandomQuestion = _questions[randomQuestion.Next(_questions.Count)];

        return _displayRandomQuestion;
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        string _displayRandomPrompt = _prompts[randomPrompt.Next(_prompts.Count)];

        return _displayRandomPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}
