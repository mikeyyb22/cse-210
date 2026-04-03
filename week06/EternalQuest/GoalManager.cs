using System.IO.Pipelines;
using System.Runtime.CompilerServices;

public class GoalManager
{

    private List<Goal> _goals;
    private int _score;
    private string _rank;
    private int _nextRankUp;
    private Dictionary<int, Dictionary<string, object>> _levels;

    private string filePath = "LevelUp.csv";

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _levels = ReadFromCSV(filePath);
        _rank = (string)_levels[0]["rankName"];
    }

    public void Start()
    {
        // Menu loop
        bool userMenu = true;
        while (userMenu == true)
        {
            Console.WriteLine("Welcome to the EternalQuest Program. Please choose your mission below: ");
            Console.WriteLine("1. New mission\n2. Log mission\n3. View current missions\n4. Show current rank\n5. Save mission progress\n6. Load mission progress\n7. Quit");
            Console.Write("Choose an option above: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                // Allow user to create new goals of any type
                CreateGoal();
            }
            else if (userChoice == 2)
            {
                // Allow user to record an event (accomplishing a goal)
                RecordEvent();
            }
            else if (userChoice == 3)
            {
                ListGoalDetails();
            }
            else if (userChoice == 4)
            {
                DisplayPlayerInfo();
            }
            else if (userChoice == 5)
            {
                SaveGoals();
            }
            else if (userChoice == 6)
            {
                LoadGoals();
            }
            else
            {
                userMenu = false;
            }
        }
    }

    public Dictionary<int, Dictionary<string, object>> ReadFromCSV(string path)
    {
        string[] lines = File.ReadAllLines(path);
        string[] headers = lines[0].Split(',');

        var levelup = new Dictionary<int, Dictionary<string, object>>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            var rowDict = new Dictionary<string, object>();
            for (int j = 0; j < headers.Length; j++)
            {
                string val = values[j];
                // Check if val is number
                if (int.TryParse(val, out int intVal))
                {
                    rowDict[headers[j]] = intVal;
                }
                else
                {
                    rowDict[headers[j]] = val;
                }
            }
            levelup[i - 1] = rowDict;
        }
        return levelup;
    }

    public void DisplayPlayerInfo()
    {
        var currentAndNext = _levels.Values.Zip(_levels.Values.Skip(1));
        foreach (var (current, next) in currentAndNext)
        {
            if (_score < (int)next["xpRequired"])
            {
                _nextRankUp = (int)next["xpRequired"];
                break;
            }
        }
        Console.WriteLine($"Current rank: {_rank}");
        Console.WriteLine($"XP to next rank: {_score}/{_nextRankUp}");
    }

    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    public void ListGoalDetails()
    {
        string checkbox = "";
        Console.WriteLine("Mission List: ");
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete() == true)
            {
                checkbox = "[x]";
            }
            else
            {
                checkbox = "[ ]";
            }
            Console.WriteLine($"{checkbox} {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.Write("What will your mission be called? ");
        string goalName = Console.ReadLine();
        Console.Write("Input mission details: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Input difficulty level (1-10): ");
        int goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine("What kind of mission will this be?\n1. One-time mission\n2. Eternal mission\n3. Repeated mission\n4. Quit");
        int goalType = int.Parse(Console.ReadLine());
        if (goalType == 1)
        {
            SimpleGoal simple1 = new SimpleGoal(goalName, goalDescription, (goalPoints * 100));
            _goals.Add(simple1);
        }
        else if (goalType == 2)
        {
            EternalGoal eternal1 = new EternalGoal(goalName, goalDescription, (goalPoints * 10));
            _goals.Add(eternal1);
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this task need to be done for the mission to be complete? ");
            int target = int.Parse(Console.ReadLine());
            ChecklistGoal checklist1 = new ChecklistGoal(goalName, goalDescription, (goalPoints * 10), target, (goalPoints * 100));
            _goals.Add(checklist1);
        }
        else
        {
            Console.WriteLine("Returning...");
            Thread.Sleep(1000);
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no missions. Returning...");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("Please choose which mission to record: ");
            ListGoalNames();
            Console.WriteLine("Choose the mission you completed: ");
            int completeMission = int.Parse(Console.ReadLine()) - 1;
            if (_goals[completeMission].IsComplete() == true)
            {
                Console.WriteLine("Mission has already been completed. Returning...");
                Thread.Sleep(1000);
            }
            else
            {
                _goals[completeMission].RecordEvent();
                int oldScore = _score;
                _score += _goals[completeMission].GetPoints();
                XPHandler(oldScore, _score);
            }
        }
    }

    public void XPHandler(int oldXp, int xp)
    {
        var currentAndNext = _levels.Values.Zip(_levels.Values.Skip(1));
        foreach (var (current, next) in currentAndNext)
        {
            if (xp >= (int)next["xpRequired"] && (int)next["xpRequired"] > oldXp)
            {
                _rank = (string)next["rankName"];
                Console.WriteLine($"Congratulations! You leveled up. Your current rank is {(string)next["rankName"]}");
            }
        }
    }

    public void SaveGoals()
    {
        string filename = "missions.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score:{_score},{_rank}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType()}:{goal.GetStringRepresentation()},{goal.GetPoints()}");
            }
        }
    }

    public void LoadGoals()
    {
        string filename = "missions.txt";
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved missions found.");
            Thread.Sleep(1000);
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);

        string[] firstLineParts = lines[0].Split(":");
        string[] scoreAndRank = firstLineParts[1].Split(",");

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(data[0], data[1], int.Parse(data[3]));
                if (bool.Parse(data[2]))
                {
                    simpleGoal.RecordEvent();
                }
                _goals.Add(simpleGoal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(data[0], data[1], int.Parse(data[3]));
                _goals.Add(eternalGoal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(data[0], data[1], int.Parse(data[6]), int.Parse(data[3]), int.Parse(data[4]));
                int amountCompleted = int.Parse(data[5]);
                for (int j = 0; j < amountCompleted; j++)
                {
                    checklistGoal.RecordEvent();
                }
                _goals.Add(checklistGoal);
            }
        }
        Console.WriteLine("Missions loaded successfully.");
    }
}