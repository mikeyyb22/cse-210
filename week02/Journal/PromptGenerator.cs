// Generate prompts for user to respond

class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPromptNumber = random.Next(_prompts.Count);
        return _prompts[randomPromptNumber];
    }
}
