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
        // // Select random prompt to show to user
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(5);
        // // After, ask user to reflect on questions that relate to the experience.
        Console.WriteLine("Please reflect on the following questions that relate to this experience.");
        ShowSpinner(5);
        DisplayQuestions();
    }

    // Get random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count - 1);
        Console.WriteLine(randomNumber);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }

    // Get random question from prompt
    public string GetRandomQuestion()
    {
        Random random2 = new Random();
        int questionIndex = random2.Next(0, _questions.Count - 1);
        string randomQuestion = _questions[questionIndex];
        _questions.Remove(_questions[questionIndex]);

        return randomQuestion;
    }

    // // Display prompt
    // public void DisplayPrompt()
    // {

    // }

    // Display questions about prompt and get answers
    public void DisplayQuestions()
    {
        int numQuestions = GetDuration() / 10;
        // Pause for several seconds before continuing to next question
        for (int i = 0; i < numQuestions; i++)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(10);
        }
        // Continue until reaching # of seconds user specified
    }

}