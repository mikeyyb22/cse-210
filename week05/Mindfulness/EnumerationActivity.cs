public class EnumerationActivity : Activity
{

    private int _count;
    private List<string> _prompts;

    public EnumerationActivity(int count, List<string> prompts, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    // Run activity
    public void Run()
    {

    }

    // Get random prompt
    public string GetRandomPrompt()
    {
        return "";
    }

    // Get list of responses from user
    public List<string> GetListFromUser()
    {
        return null;
    }

}