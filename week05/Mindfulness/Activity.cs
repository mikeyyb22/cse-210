public class Activity
{

    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "Activity";
        _description = "A mindfulness activity";
        _duration = 50;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    private void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Display start message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} program. {_description} Please enter the desired duration in seconds: ");
        int activityDuration = Console.Read();
        SetDuration(activityDuration);
    }

    // Display end message
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You have completed the {_name} program. You completed {_duration} seconds of this program. That\'s something to celebrate!");
        ShowSpinner(2);
    }

    // Pause while showing spinner
    public void ShowSpinner(int seconds)
    {
        int spinnerCycles = seconds * 10;

        char[] chars = { '|', '/', '-', '\\' };

        for (int i = 0; i < spinnerCycles; i++)
        {
            char currentSeparator = chars[i % chars.Length]
;
            Console.Write(currentSeparator);
            Thread.Sleep(spinnerCycles);
            Console.Write("\b");
        }
    }

    // Pause while showing countdown
    public void ShowCountdown(int second)
    {

        for (int i = 0; i <= second; i++)
        {
            Console.Write(second - i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

    }
}