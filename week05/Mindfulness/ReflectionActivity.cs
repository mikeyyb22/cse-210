public class ReflectionActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(List<string> prompts, List<string> questions, string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
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

    // Get random question from prompt
    public string GetRandomQuestion()
    {
        return "";
    }

    // Display prompt
    public void DisplayPrompt()
    {

    }

    // Display questions about prompt and get answers
    public void DisplayQuestions()
    {

    }

}