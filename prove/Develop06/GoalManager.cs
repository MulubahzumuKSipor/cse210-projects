public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private int _userInput = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (_userInput != 6)
        {
            Console.WriteLine(
                $@"You have {_score} points.

Menu Options:
    1. Create New goal
    2. List goals
    3. Save goals
    4. Load goals
    5. Record Event
    6. Quit
Select a choice from the menu: "
            );
            _userInput = int.Parse(Console.ReadLine());

            if (_userInput == 1)
            {
                CreateGoal();
            }
            else if (_userInput == 2)
            {
                DisplayPlayerInfo();
            }
            else if (_userInput == 3)
            {
                SaveGoals();
            }
            else if (_userInput == 4)
            {
                LoadGoals();
            }
            else if (_userInput == 5)
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        foreach (Goal name in _goals)
        {
            Console.WriteLine($"{name.GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine(
            @"The types of goals are:
    1. Simple goals
    2. Eternal goals
    3. Checklist goals
Which type of goals would you like to create: "
        );
        int _type = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal: ");
        string points = Console.ReadLine();

        if (_type == 1)
        {
            _goals.Add(new Simple(name, description, points));
        }
        else if (_type == 2)
        {
            _goals.Add(new Eternal(name, description, points));
        }
        else if (_type == 3)
        {
            Console.WriteLine(
                "How many times does this goal needs to be accomplished for a bonus: "
            );
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new Checklist(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        DisplayPlayerInfo();
        Console.Write("Which goal did u accomplish: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            int converted = int.Parse(goal.GetPoints());
            goal.RecordEvent();
            _score += goal.IsComplete()
                ? goal is Checklist checklist && checklist.IsComplete()
                    ? checklist.GetBonus()
                    : converted
                : converted;
        }
        else
        {
            Console.WriteLine("Goal is not available.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                if (goal is Simple simple)
                    outputFile.WriteLine(
                        $"SimpleGoal|{simple.GetName()}|{simple.GetDescription()}|{simple.GetPoints()}|{simple.IsComplete()}"
                    );
                else if (goal is Eternal eternal)
                    outputFile.WriteLine(
                        $"EternalGoal|{eternal.GetName()}|{eternal.GetDescription()}|{eternal.GetPoints()}"
                    );
                else if (goal is Checklist checklist)
                    outputFile.WriteLine(
                        $"Checklist|{checklist.GetName()}|{checklist.GetDescription()}|{checklist.GetPoints()}|{checklist.GetTarget()}|{checklist.GetBonus()}|{checklist.GetDetailString().Split(' ')[1]}"
                    );
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        if (File.Exists(filename))
        {
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[1];

                if (string.IsNullOrWhiteSpace(line)) // Skip blank lines
                    continue;

                string[] parts = line.Split("|");
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    var simpleGoal = new Simple(name, description, points);
                    if (isComplete)
                    {
                        simpleGoal.RecordEvent(); // Mark as complete
                    }
                    _goals.Add(simpleGoal);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new Eternal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);
                    var checklistGoal = new Checklist(name, description, points, target, bonus);
                    for (int j = 0; j < completed; j++)
                    {
                        checklistGoal.RecordEvent(); // Simulate progress
                    }
                    _goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine($"Unavailable goal type: {type}");
                }
            }
        }
    }
}
