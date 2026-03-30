public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    // Run activity
    public void Run()
    {
        // Number of breaths taken (assuming each breath in/out takes 3 seconds, then rounding up)
        int numItems = GetDuration() / 10;

        // Show series of messages alternating between "Breathe in..." and "Breathe out..." pausing several seconds between, showing a countdown
        for (int i = 0; i < numItems; i++)
        {
            Console.Clear();
            Console.Write("Breathe In...");
            ShowCountdown(5);
            Console.Clear();
            Console.Write("Breathe Out...");
            ShowCountdown(5);
        }

        Console.Clear();
    }
}