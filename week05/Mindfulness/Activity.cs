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

    // Display start message
    public void DisplayStartingMessage()
    {

    }

    // Display end message
    public void DisplayEndingMessage()
    {

    }

    // Pause while showing spinner
    public void ShowSpinner(int seconds)
    {

    }

    // Pause while showing countdown
    public void ShowCountdown(int second)
    {

    }
}