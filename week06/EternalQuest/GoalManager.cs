public class GoalManager
{

    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
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
            else
            {
                userMenu = false;
            }
        }
    }

    public void DisplayPlayerInfo()
    {

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
                if (_goals[completeMission].IsComplete() == true)
                {
                    _score += _goals[completeMission].GetPoints();
                }
            }
        }
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}